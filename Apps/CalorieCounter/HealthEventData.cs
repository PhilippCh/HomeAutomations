using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

public record HealthEventData
{
	[JsonPropertyName("user")]
	public string? User { get; init; }

	[JsonPropertyName("resting_kcal")]
	public double? RestingCalories { get; init; }

	[JsonPropertyName("active_kcal")]
	public double? ActiveCalories { get; init; }
}
