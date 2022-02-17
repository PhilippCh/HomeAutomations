using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

public record DigestCaloriesEventData
{
	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("kcal")]
	public string? Calories { get; init; }
}
