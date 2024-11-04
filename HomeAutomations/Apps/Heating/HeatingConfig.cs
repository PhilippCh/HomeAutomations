using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Heating;

public record ThermostatConfig
{
	public string Name { get; init; }
	public SwitchEntity WindowOpenSwitch { get; init; }
	public IEnumerable<BinarySensorEntity> WindowSensors { get; init; }
}

public record HeatingConfig : Config
{
	public TimeSpan SensorDebounceTime { get; init; }
	public IEnumerable<ThermostatConfig> Thermostats { get; init; }
}
