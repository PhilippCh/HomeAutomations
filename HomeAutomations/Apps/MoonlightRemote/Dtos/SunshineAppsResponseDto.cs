using System.Collections.Generic;
using Newtonsoft.Json;

namespace HomeAutomations.Apps.MoonlightRemote.Dtos;

public record SunshineAppsResponseDto
{
	[JsonProperty("apps")]
	public List<SunshineAppResponseDto> Apps { get; init; }
}
