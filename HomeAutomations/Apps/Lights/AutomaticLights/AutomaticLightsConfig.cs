using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

public record BrightnessConfig
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }
	public int Percentage { get; init; }
}

public record AutomaticLightEntity
{
	public LightEntity Entity { get; init; }
	public TimeSpan CycleTime { get; init; }
	public int MinIlluminance { get; init; }
	public SensorEntity ManualTriggerSensor { get; init; }
	public BinarySensorEntity MotionSensor { get; init; }
	public IEnumerable<BrightnessConfig> Brightness { get; init; }
}

public record LightGroup
{
	public string Name { get; init; }
	public IEnumerable<AutomaticLightEntity> Lights { get; init; }
}

public record AutomaticLightsConfig : Config
{
	public IEnumerable<LightGroup> Groups { get; init; }
}
