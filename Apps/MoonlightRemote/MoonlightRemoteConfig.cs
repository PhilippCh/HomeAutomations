using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MoonlightRemote;

public record GameInfo
{
	public string Id { get; init; }
	public string DisplayName { get; init; }
}

public record MoonlightHost
{
	public string DisplayName { get; init; }
	public string Host { get; init; }
	public string MacAddress { get; init; }
	public IEnumerable<GameInfo> Games { get; init; }

	public GameInfo? GetGameByDisplayName(string? displayName) => Games.FirstOrDefault(g => g.DisplayName == displayName);
}

public record MoonlightRemoteConfig : Config
{
	public InputNumberEntity Pid { get; init; }
	public InputTextEntity CurrentHost { get; init; }
	public InputBooleanEntity ShutdownHost { get; init; }
	public InputBooleanEntity ShutdownHarmony { get; init; }
	public string ApiBaseUrl { get; init; }
	public InputSelectEntity SelectedHost { get; init; }
	public InputSelectEntity SelectedGame { get; init; }
	public IEnumerable<MoonlightHost> Hosts { get; init; }
}
