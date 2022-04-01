using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.NighttimeSwitch;

public record NighttimeSwitchConfig : Config
{
	public string ScheduleCrontab { get; init; }
	public SensorEntity LocationSensor { get; init; }
	public InputNumberEntity InputNumber { get; init; }
}
