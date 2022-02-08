using System;
using System.Collections.Generic;
using HomeAssistant.Automations.Models;

namespace HomeAssistant.Automations.Apps.KitchenLight;

public record BrightnessConfig
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }
	public int Percentage { get; init; }
}

public record KitchenLightConfig : Config
{
	public string LightEntityId { get; init; }
	public int MinIlluminanceLux { get; init; }
	public string CombinedSensorTopic { get; init; }
	public string ManualTriggerSensorTopic { get; init; }
	public TimeSpan CycleTime { get; init; }
	public IEnumerable<BrightnessConfig> Brightness { get; init; }
}
