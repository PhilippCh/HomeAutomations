using System;
using System.Collections.Generic;
using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.KitchenLight;

public class BrightnessConfig
{
	public TimeSpan Start { get; set; }
	public TimeSpan End { get; set; }
	public int Percentage { get; set; }
}

public class KitchenLightConfig : Config
{
	public int MinIlluminanceLux { get; set; }
	public string CombinedSensorTopic { get; set; }
	public string ManualTriggerSensorTopic { get; set; }
	public TimeSpan CycleTime { get; set; }
	public IEnumerable<BrightnessConfig> Brightness { get; set; }
}
