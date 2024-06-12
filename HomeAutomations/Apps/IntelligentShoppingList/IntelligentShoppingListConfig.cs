using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.IntelligentShoppingList;

public record IntelligentShoppingListConfig : Config
{
	public string ServiceName { get; init; }
	public TodoEntity InputListEntity { get; init; }
	public IEnumerable<string> IgnoredItems { get; init; }
	public IEnumerable<ShoppingListBucket> Buckets { get; init; }
	public string SystemPrompt { get; init; }
}

public record ShoppingListBucket
{
	public string Name { get; init; }
	public TodoEntity Entity { get; init; }
	public string Predicate { get; init; }
}
