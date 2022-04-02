using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.MovieTime;

public record RokuCommandEventData
{
	public const string Id = "roku_command";

	[JsonPropertyName("source_name")]
	public string DeviceName { get; init; }

	[JsonPropertyName("type")]
	public string Type { get; init; }

	[JsonPropertyName("key")]
	public string Key { get; init; }
}
