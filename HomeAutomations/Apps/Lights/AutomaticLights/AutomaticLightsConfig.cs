using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

public record AutomaticLightEntity
{
	public LightEntity Entity { get; init; }
	public SensorEntity ManualTriggerSensor { get; init; }
}

public record LightGroup
{
	public string Name { get; init; }
	public BinarySensorEntity MotionSensor { get; init; }
	public TimeSpan CycleTime { get; init; }
	public int MinIlluminance { get; init; }
	public IEnumerable<AutomaticLightEntity> Lights { get; init; }
}

public record AutomaticLightsConfig : Config
{
	public IEnumerable<LightGroup> Groups { get; init; }
}
