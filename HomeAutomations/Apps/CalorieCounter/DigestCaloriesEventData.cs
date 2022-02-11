using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

public record DigestCaloriesEventData
{
	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("kcal")]
	public double? Calories { get; init; }
}
