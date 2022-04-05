using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.TrainingSchedule;

public record TrainingServiceData
{
	[JsonPropertyName("url")]
	public string Url { get; init; }
}
