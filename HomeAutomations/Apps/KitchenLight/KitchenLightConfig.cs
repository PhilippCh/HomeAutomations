using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.KitchenLight;

public record BrightnessConfig
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }
	public int Percentage { get; init; }
}

public record KitchenLightConfig : Config
{
	public LightEntity LightEntity { get; init; }
	public int MinIlluminanceLux { get; init; }
	public string CombinedSensorTopic { get; init; }
	public string ManualTriggerSensorTopic { get; init; }
	public TimeSpan CycleTime { get; init; }
	public IEnumerable<BrightnessConfig> Brightness { get; init; }
}
