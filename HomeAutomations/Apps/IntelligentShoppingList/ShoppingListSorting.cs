using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.IntelligentShoppingList;

public record ShoppingListSorting
{
	[JsonPropertyName("item")]
	public string ItemName { get; init; }

	[JsonPropertyName("bucketId")]
	public string BucketId { get; init; }
}
