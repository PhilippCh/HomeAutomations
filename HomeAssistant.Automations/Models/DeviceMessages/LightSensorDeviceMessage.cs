using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models.DeviceMessages;

/// <summary>
/// Xiaomi light sensor zigbee mapping.
/// </summary>
public class LightSensorDeviceMessage : ZigbeeDeviceMessage
{
	[JsonPropertyName("illuminance")]
	public int? Illuminance { get; set; }

	[JsonPropertyName("illuminance_lux")]
	public int? IlluminanceLux { get; set; }
}
