using System;
using System.Collections.Generic;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Models;
using HomeAutomations.Models;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

public record CalorieCounterConfig : Config
{
	public int MinIlluminanceLux { get; init; }
	public string CombinedSensorTopic { get; init; }
	public string ManualTriggerSensorTopic { get; init; }
	public TimeSpan CycleTime { get; init; }
	public IEnumerable<BrightnessConfig> Brightness { get; init; }
}
