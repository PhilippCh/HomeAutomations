using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.WallPanel;

public record WallPanelTopicConfig
{
	public string DeviceInfo { get; init; }
}

public record WallPanelConfig
{
	public string Name { get; init; }
	public string DeviceId { get; init; }
	public SwitchEntity Switch { get; init; }
	public IEnumerable<string>? PluggedRestCommands { get; init; }
	public IEnumerable<string>? UnpluggedRestCommands { get; init; }
}

public record WallPanelMonitorConfig : Config
{
	public IEnumerable<WallPanelConfig> Panels { get; init; }
	public WallPanelTopicConfig Topics { get; init; }
	public Range<double> OffRange { get; init; }
}
