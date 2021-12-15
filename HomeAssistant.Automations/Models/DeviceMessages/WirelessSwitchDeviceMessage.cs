using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models.DeviceMessages;

/// <summary>
/// Aqara wireless switch zigbee mapping.
/// </summary>
public class WirelessSwitchDeviceMessage : ZigbeeDeviceMessage
{
	[JsonPropertyName("illuminance")]
	public int Illuminance { get; set; }

	[JsonPropertyName("illuminance_lux")]
	public int IlluminanceLux { get; set; }
}
