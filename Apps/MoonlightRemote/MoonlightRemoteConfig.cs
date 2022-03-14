using System.Collections.Generic;
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
	public string Name { get; init; }
	public IEnumerable<GameInfo> Games { get; init; }
}

public record MoonlightRemoteConfig : Config
{
	public VarEntity PidVar { get; init; }
	public string ApiBaseUrl { get; init; }
	public IEnumerable<MoonlightHost> Hosts { get; init; }
}
