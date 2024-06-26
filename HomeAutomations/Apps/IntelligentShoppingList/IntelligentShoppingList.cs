using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Services.Graph;
using HomeAutomations.Common.Services.Graph.Filters;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services.LLM;
using Microsoft.Graph.Models;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Integration;
using Polly;
using Polly.Retry;

namespace HomeAutomations.Apps.IntelligentShoppingList;

[Focus]
public class IntelligentShoppingList : BaseAutomation<IntelligentShoppingList, IntelligentShoppingListConfig>
{
	private readonly ILlmService _llmService;
	private readonly GraphTodoClient _graphTodoClient;

	private string? _systemPrompt;

	// ReSharper disable once ConvertToPrimaryConstructor | Primary constructor displays values as null, see https://github.com/dotnet/roslyn/issues/70730.
	public IntelligentShoppingList(
		BaseAutomationDependencyAggregate<IntelligentShoppingList, IntelligentShoppingListConfig> aggregate,
		ILlmService llmService,
		GraphTodoClient graphTodoClient)
		: base(aggregate)
	{
		_llmService = llmService;
		_graphTodoClient = graphTodoClient;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_systemPrompt = CreateSystemPrompt();

		// Push authentication device requests to the frontend.
		_graphTodoClient.DeviceCodeRequest.Subscribe(x => Config.AuthenticationDeviceCodeEntity.SetValue(x ?? EntityStates.Unavailable));

		Context.RegisterServiceCallBack<SortShoppingListServiceData>(Config.ServiceName, _ => SortShoppingList());
		Config.ProgressEntity.TurnOff();

		return Task.CompletedTask;
	}

	private async void SortShoppingList()
	{
		Logger.Information("Begin sorting shopping list via LLM prompt ({RunType})", Config.DryRunEntity.IsOn() ? "dry run" : "live");
		Config.ProgressEntity.TurnOn();

		var response = await _graphTodoClient.GetTodoTasksAsync(Config.InputListId, new TaskNotStartedFilter());
		var tasks = response?.Value?
			.Where(x => !Config.IgnoredItems.Contains(x.Title))
			.ToList();

		if (tasks == null)
		{
			Logger.Warning("Did not receive a task list from Graph call");
			Config.ProgressEntity.TurnOff();

			return;
		}

		var sortedItems = await SortItemsWithLlmAsync(tasks);
		if (sortedItems == null)
		{
			Logger.Warning("An error occurred when getting the LLM response");
			Config.ProgressEntity.TurnOff();

			return;
		}

		var itemsByTargetBucket = sortedItems.GroupBy(x => x.BucketId);

		foreach (var group in itemsByTargetBucket)
		{
			await SortTasksIntoTargetBucketAsync(group, tasks);
		}

		Logger.Information("Sorting of {Count} items completed", tasks.Count);
		Config.ProgressEntity.TurnOff();
	}

	private async Task SortTasksIntoTargetBucketAsync(IGrouping<string, ShoppingListSorting> group, List<TodoTask> originalTasks)
	{
		var targetBucket = Config.Buckets.FirstOrDefault(x => x.Name == group.Key);

		if (targetBucket == null)
		{
			Logger.Warning("Could not find bucket with id {BucketId}", group.Key);

			return;
		}

		Logger.Debug("Deleting all todos in bucket {BucketName}", targetBucket.Name);
		await OnlyInWetRunAsync(async () => await _graphTodoClient.DeleteAllTodosAsync(targetBucket.ListId));
		await group.ForEachAsync(async x => await MoveToTargetBucket(x, targetBucket, originalTasks));
	}

	private string CreateSystemPrompt()
	{
		var buckets = Config.Buckets.Select(x => $"{x.Name}: {x.Predicate}");
		var bucketList = string.Join("\r\n", buckets);

		return Config.SystemPrompt.Replace("%BUCKETS%", bucketList);
	}

	private async Task<IEnumerable<ShoppingListSorting>?> SortItemsWithLlmAsync(IEnumerable<TodoTask>? tasks)
	{
		if (_systemPrompt == null)
		{
			Logger.Error("Could not get system prompt from config");

			return null;
		}

		var itemList = string.Join("\r\n", tasks?.Select(x => x.Title) ?? []);
		var prompt = _systemPrompt.Replace("%ITEMS%", itemList);

		Logger.Debug("Calling LLM");
		var pipeline = new ResiliencePipelineBuilder()
			.AddRetry(new RetryStrategyOptions())
			.Build();

		var sortedItems = await pipeline.ExecuteAsync(
			async _ =>
			{
				var result = await _llmService.CreateCompletionAsync(prompt) ?? "invalid";

				return JsonSerializer.Deserialize<IEnumerable<ShoppingListSorting>>(result);
			});

		return sortedItems;
	}

	private async Task OnlyInWetRunAsync(Func<Task> action)
	{
		if (Config.DryRunEntity.EntityState?.IsOffOrUnavailable() ?? false)
		{
			await action();
		}
	}

	private async Task MoveToTargetBucket(ShoppingListSorting item, ShoppingListBucket targetBucket, List<TodoTask> originalTasks)
	{
		Logger.Debug("Creating todo for item {ItemName} in bucket {BucketName}", item.ItemName, targetBucket.Name);

		var originalTask = originalTasks.FirstOrDefault(x => x.Title == item.ItemName);
		await OnlyInWetRunAsync(async () => await _graphTodoClient.CloneTaskToListAsync(targetBucket.ListId, originalTask));
	}
}
