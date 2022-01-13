using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.KitchenLight;

[UsedImplicitly]
public class MotionSensorConfig
{
	public string Host { get; set; }
	public int PingIntervalMs { get; set; } = 500;
	public int ThrottleAfterWakeSeconds { get; set; } = 30;
}

public class KitchenLightConfig : Config
{
	public MotionSensorConfig MotionSensor { get; set; }
	public int MinIlluminanceLux { get; set; }
	public string LightSensorTopic { get; set; }
	public string ManualTriggerSensorTopic { get; set; }
	public int CycleTimeMinutes { get; set; }
}
