using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services.Graph;
using HomeAutomations.Common.Services.Graph.Filters;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services.LLM;
using Microsoft.Graph.Models;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.IntelligentShoppingList;

[Focus]
public class IntelligentShoppingList : BaseAutomation<IntelligentShoppingList, IntelligentShoppingListConfig>
{
	private readonly ILlmService _llmService;
	private readonly GraphTodoClient _graphTodoClient;
	private readonly IMqttEntityManager _entityManager;

	private string? _systemPrompt;

	// ReSharper disable once ConvertToPrimaryConstructor | Primary constructor displays values as null, see https://github.com/dotnet/roslyn/issues/70730.
	public IntelligentShoppingList(
		BaseAutomationDependencyAggregate<IntelligentShoppingList, IntelligentShoppingListConfig> aggregate,
		ILlmService llmService,
		GraphTodoClient graphTodoClient,
		IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_llmService = llmService;
		_graphTodoClient = graphTodoClient;
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_systemPrompt = CreateSystemPrompt();
		Context.RegisterServiceCallBack<SortShoppingListServiceData>(Config.ServiceName, _ => SortShoppingList());

		await _entityManager.CreateAsync(Config.ProgressEntity.EntityId, new EntityCreationOptions(null, Config.ProgressEntity.EntityId, "Intelligent shopping list sort in progress"));
		Config.ProgressEntity.TurnOff();
	}

	private async void SortShoppingList()
	{
		Logger.Information("Begin sorting shopping list via LLM prompt");
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
			var targetBucket = Config.Buckets.FirstOrDefault(x => x.Name == group.Key);

			if (targetBucket == null)
			{
				Logger.Warning("Could not find bucket with id {BucketId}", group.Key);

				continue;
			}

			Logger.Debug("Deleting all todos in bucket {BucketName}", targetBucket.Name);
			await _graphTodoClient.DeleteAllTodosAsync(targetBucket.ListId);

			foreach (var item in group)
			{
				Logger.Debug("Creating todo for item {ItemName} in bucket {BucketName}", item.ItemName, targetBucket.Name);
				await _graphTodoClient.AddTaskToListAsync(targetBucket.ListId, item.ItemName);
			}
		}

		Logger.Information("Sorting of {Count} items completed", tasks.Count);
		Config.ProgressEntity.TurnOff();
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
		var result = await _llmService.CreateCompletionAsync(prompt);

		if (result == null)
		{
			return [];
		}

		var sortedItems = JsonSerializer.Deserialize<IEnumerable<ShoppingListSorting>>(result);

		return sortedItems;
	}
}
