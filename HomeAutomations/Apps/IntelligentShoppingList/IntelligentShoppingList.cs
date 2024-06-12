using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Services.LLM;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.IntelligentShoppingList;

[Focus]
public class IntelligentShoppingList(
	BaseAutomationDependencyAggregate<IntelligentShoppingList, IntelligentShoppingListConfig> aggregate,
	ILlmService llmService) : BaseAutomation<IntelligentShoppingList, IntelligentShoppingListConfig>(aggregate)
{
	private string? _systemPrompt;

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_systemPrompt = CreateSystemPrompt();
		Context.RegisterServiceCallBack<SortShoppingListServiceData>(Config.ServiceName, _ => SortShoppingList());

		return Task.CompletedTask;
	}

	private async void SortShoppingList()
	{
		var todoItems = TodoItem.FromJsonElements(Config.InputListEntity.Attributes?.AllTodos?.OfType<JsonElement>());
		var delta = TodoItemDelta.ById(null, todoItems?.ToList());
		var addedItems = delta.Added.Where(x => !Config.IgnoredItems.Contains(x.Id));

		var sortedItems = await SortItemsWithLlmAsync(addedItems);
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

		var result = await llmService.CreateCompletionAsync(prompt);

		if (result == null)
		{
			return [];
		}

		var sortedItems = JsonSerializer.Deserialize<IEnumerable<ShoppingListSorting>>(result);

		return sortedItems;
	}
}
