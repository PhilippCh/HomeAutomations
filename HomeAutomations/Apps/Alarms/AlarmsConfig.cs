using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using JetBrains.Annotations;

namespace HomeAutomations.Apps.Alarms;

[UsedImplicitly]
public record AlarmSensorConfig
{
	public string Name { get; init; }
	public BinarySensorEntity Entity { get; init; }
	public Notification OnNotification { get; init; }
	public Notification OffNotification { get; init; }
}

public record AlarmsConfig : Config
{
	public IEnumerable<AlarmSensorConfig> Sensors { get; init; }
}
