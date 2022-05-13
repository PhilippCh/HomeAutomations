using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Lights.KitchenLight;

public record BrightnessConfig
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }
	public int Percentage { get; init; }
}

public record KitchenLightConfig : Config
{
	public LightEntity LightEntity { get; init; }
	public int MinIlluminance { get; init; }
	public BinarySensorEntity MotionSensor { get; init; }
	public SensorEntity ManualTriggerSensor { get; init; }
	public TimeSpan CycleTime { get; init; }
	public IEnumerable<BrightnessConfig> Brightness { get; init; }
}
