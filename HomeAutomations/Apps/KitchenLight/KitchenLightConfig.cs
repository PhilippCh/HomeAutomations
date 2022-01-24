using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.KitchenLight;

public class KitchenLightConfig : Config
{
	public int MinIlluminanceLux { get; set; }
	public string SensorTopic { get; set; }
	public string ManualTriggerSensorTopic { get; set; }
	public int CycleTimeMinutes { get; set; }
}
