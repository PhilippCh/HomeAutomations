using System.Collections.Generic;
using HomeAutomations.Apps.ComputerSpeakers;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.ComputerSwitches;

public record HostConfig
{
	public string Name { get; init; }
	public InputBooleanEntity Entity { get; init; }
	public string Host { get; init; }
	public string MacAddress { get; init; }
}

public record ComputerSwitchesConfig : Config
{
	public StagedConfig<string> ApiBaseUrl { get; init; }
	public IEnumerable<HostConfig> Hosts { get; init; }
}
