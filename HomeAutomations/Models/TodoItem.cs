using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using HomeAutomations.Common.Extensions;

namespace HomeAutomations.Models;

public class TodoItemDelta
{
	public IReadOnlyCollection<TodoItem> Added { get; init; }
	public IReadOnlyCollection<TodoItem> Removed { get; init; }

	public static TodoItemDelta ById(ICollection<TodoItem>? oldItems, ICollection<TodoItem>? newItems)
	{
		if (oldItems == null && newItems == null)
		{
			return new TodoItemDelta { Added = [], Removed = []};
		}

		if (oldItems == null)
		{
			return new TodoItemDelta { Added = newItems!.ToList(), Removed = []};
		}

		if (newItems == null)
		{
			return new TodoItemDelta { Added = [], Removed = oldItems!.ToList()};
		}

		var newItemIds = newItems.Select(x => x.Id).ToList();
		var oldItemIds = oldItems.Select(x => x.Id).ToList();

		var addedItemIds = newItemIds.Except(oldItemIds);
		var removedItemIds = oldItemIds.Except(newItemIds);

		return new TodoItemDelta
		{
			Added = newItems.Select(x => x).Where(x => addedItemIds.Contains(x.Id)).ToList(),
			Removed = oldItems.Select(x => x).Where(x => removedItemIds.Contains(x.Id)).ToList()
		};
	}
}

public class TodoItem
{
	[JsonPropertyName("todo_id")]
	public string Id { get; set; }

	[JsonPropertyName("subject")]
	public string Name { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	public static IEnumerable<TodoItem>? FromJsonElements(IEnumerable<JsonElement>? jsonElements) =>
		jsonElements?
			.Select(x => x.Deserialize<TodoItem>())
			.WhereNotNull();
}
