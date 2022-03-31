using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.CalorieCounter;

public record DigestCaloriesEventData
{
	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("kcal")]
	public string? Calories { get; init; }
}
