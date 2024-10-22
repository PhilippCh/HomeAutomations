using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.ComputerSwitches;

public record HostConfig
{
	public string? Id { get; init; }
	public string? MacAddress { get; init; }
	public ButtonEntity ShutdownButton { get; init; }
}

public record ComputerSwitchesConfig : Config
{
	public IEnumerable<HostConfig> Hosts { get; init; }
}
