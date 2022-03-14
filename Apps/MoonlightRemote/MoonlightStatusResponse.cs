using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.MoonlightRemote;

public record MoonlightStatusResponse
{
	[JsonPropertyName("isRunning")]
	public bool IsRunning { get; init; }

	[JsonPropertyName("pid")]
	public int Pid { get; init; }
}
