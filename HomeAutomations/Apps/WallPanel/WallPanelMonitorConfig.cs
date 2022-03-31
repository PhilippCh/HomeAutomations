using System.Collections.Generic;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.WallPanel;

public record WallPanelConfig
{
	public string Name { get; init; }
	public string BaseTopic { get; init; }
	public SwitchEntity Switch { get; init; }
}

public record WallPanelMonitorConfig : Config
{
	public IEnumerable<WallPanelConfig> Panels { get; init; }

	public Range<double> OffRange { get; init; }
}
