using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.CalorieCounter;

public record DigestCaloriesEventData
{
	public const string Id = "digest_calories_event";

	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("kcal")]
	public string? Calories { get; init; }
}
