using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using JetBrains.Annotations;

namespace HomeAutomations.Apps.Alarms;

[UsedImplicitly]
public record AlarmSensorConfig
{
	public IEnumerable<BinarySensorEntity> Entities { get; init; }
	public SensorEntity BatteryEntity { get; init; }
	public Notification? OnNotification { get; init; }
	public Notification? OffNotification { get; init; }
}

public record AlarmsConfig : Config
{
	public int ReplaceBatteryThreshold { get; init; }
	public Notification? ReplaceBatteryNotification { get; init; }
	public IEnumerable<AlarmSensorConfig> Sensors { get; init; }
}
