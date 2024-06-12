using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services.LLM;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.IntelligentShoppingList;

[Focus]
public class IntelligentShoppingList : BaseAutomation<IntelligentShoppingList, IntelligentShoppingListConfig>
{
	private string? _systemPrompt;
	private readonly ILlmService _llmService;

	// ReSharper disable once ConvertToPrimaryConstructor | Primary constructor displays values as null, see https://github.com/dotnet/roslyn/issues/70730.
	public IntelligentShoppingList(BaseAutomationDependencyAggregate<IntelligentShoppingList, IntelligentShoppingListConfig> aggregate, ILlmService llmService)
		: base(aggregate)
	{
		_llmService = llmService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_systemPrompt = CreateSystemPrompt();
		Context.RegisterServiceCallBack<SortShoppingListServiceData>(Config.ServiceName, _ => SortShoppingList());

		return Task.CompletedTask;
	}

	private async void SortShoppingList()
	{
		Logger.Information("Begin sorting shopping list via LLM prompt");

		var todoItems = Config.InputListEntity.GetAllItems();
		var delta = TodoItemDelta.ById(null, todoItems?.ToList());
		var addedItems = delta.Added
			.Where(x => !Config.IgnoredItems.Contains(x.Id))
			.ToList();

		var sortedItems = await SortItemsWithLlmAsync(addedItems);

		if (sortedItems == null)
		{
			Logger.Warning("An error occurred when getting the LLM response");

			return;
		}

		var itemsByTargetBucket = sortedItems.GroupBy(x => x.BucketId);

		foreach (var group in itemsByTargetBucket)
		{
			var targetBucket = Config.Buckets.FirstOrDefault(x => x.Entity.EntityId == group.Key);

			if (targetBucket == null)
			{
				Logger.Warning("Could not find bucket with id {BucketId}", group.Key);
				continue;
			}

			targetBucket.Entity.DeleteAllItems();

			foreach (var item in group)
			{
				Services.O365.NewTodo(new ServiceTarget
				{
					EntityIds = [targetBucket.Entity.EntityId]
				}, item.ItemName);
			}
		}

		Logger.Information("Sorting of {Count} items completed", addedItems.Count());
	}

	private string CreateSystemPrompt()
	{
		var buckets = Config.Buckets.Select(x => $"{x.Entity.EntityId}: {x.Predicate}");
		var bucketList = string.Join("\r\n", buckets);

		return Config.SystemPrompt.Replace("%BUCKETS%", bucketList);
	}

	private async Task<IEnumerable<ShoppingListSorting>?> SortItemsWithLlmAsync(IEnumerable<TodoItem> items)
	{
		if (_systemPrompt == null)
		{
			Logger.Error("Could not get system prompt from config");

			return null;
		}

		var itemList = string.Join("\r\n", items.Select(x => x.Name));
		var prompt = _systemPrompt.Replace("%ITEMS%", itemList);

		var result = await _llmService.CreateCompletionAsync(prompt);

		if (result == null)
		{
			return [];
		}

		var sortedItems = JsonSerializer.Deserialize<IEnumerable<ShoppingListSorting>>(result);

		return sortedItems;
	}
}
