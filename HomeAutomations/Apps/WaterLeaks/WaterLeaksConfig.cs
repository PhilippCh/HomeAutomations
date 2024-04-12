using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.WaterLeaks;

public record WaterLeakSensorConfig
{
	public string Name { get; init; }
	public BinarySensorEntity Entity { get; init; }
}

public record WaterLeaksConfig : Config
{
	public IEnumerable<WaterLeakSensorConfig> Sensors { get; init; }

	public Notification WetNotification { get; init; }
	public Notification DryNotification { get; init; }
}
