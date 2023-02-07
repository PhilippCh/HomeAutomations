using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MoonlightRemote;

public record MoonlightHost
{
	public string DisplayName { get; init; }
	public string Host { get; init; }
	public string MacAddress { get; init; }
}

public record SunshineConfig
{
	public int Port { get; init; }
	public string AppsPath { get; init; }
	public string Username { get; init; }
	public string Password { get; init; }
}

public record MoonlightRemoteConfig : Config
{
	public SunshineConfig Sunshine { get; init; }
	public InputNumberEntity Pid { get; init; }
	public InputTextEntity CurrentHost { get; init; }
	public InputBooleanEntity ShutdownHost { get; init; }
	public InputBooleanEntity ShutdownHarmony { get; init; }
	public StagedConfig<string> ApiBaseUrl { get; init; }
	public InputSelectEntity SelectedHost { get; init; }
	public InputSelectEntity SelectedGame { get; init; }
	public IEnumerable<MoonlightHost> Hosts { get; init; }
}
