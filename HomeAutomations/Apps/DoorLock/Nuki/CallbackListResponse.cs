using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.DoorLock.Nuki;

public record CallbackResponse
{
	[JsonPropertyName("id")]
	public int Id { get; init; }

	[JsonPropertyName("url")]
	public string Url { get; init; }
}

public record CallbackListResponse
{
	[JsonPropertyName("callbacks")]
	public IEnumerable<CallbackResponse> Callbacks { get; init; }
}
