using System.Text.Json.Serialization;
using HomeAssistant.Automations.Models.DeviceMessages;

namespace HomeAutomations.Models.DeviceMessages;

/// <summary>
/// Aqara motion sensor device message.
/// This devices reports the following properties:
///   - Illuminance
///   - Illuminance (Lux)
///   - Occupancy (motion detection)
///   - Temperature in Celsius
/// </summary>
public class MotionSensorDeviceMessage : ZigbeeDeviceMessage
{
	[JsonPropertyName("illuminance")]
	public int Illuminance { get; set; }

	[JsonPropertyName("illuminance_lux")]
	public int IlluminanceLux { get; set; }

	[JsonPropertyName("occupancy")]
	public bool Occupancy { get; set; }

	[JsonPropertyName("temperature")]
	public int Temperature { get; set; }
}
