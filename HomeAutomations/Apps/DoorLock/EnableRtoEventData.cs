using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.DoorLock;

public record EnableRtoEventData
{
	public const string Id = "enable_rto_event";

	[JsonPropertyName("token")]
	public string? Token { get; init; }
}
