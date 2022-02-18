using System.Collections.Generic;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.WallPanel;

public record WallPanelConfig {

	public string Name { get; init; }
	public string BaseTopic { get; init; }

}

public record WallPanelMonitorConfig: Config
{
	public IEnumerable<WallPanelConfig> Panels { get; init; }
}
