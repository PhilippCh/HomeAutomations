using Newtonsoft.Json;

namespace HomeAutomations.Apps.MoonlightRemote.Dtos;

public record SunshineAppResponseDto
{
	[JsonProperty("name")]
	public string Name { get; init; }
}
