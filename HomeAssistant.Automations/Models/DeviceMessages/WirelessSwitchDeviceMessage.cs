using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models.DeviceMessages;

public static class WirelessSwitchActions {
	public const string Single = "single";
	public const string Double = "double";
	public const string Hold = "hold";
	public const string Release = "release";
}

/// <summary>
/// Aqara wireless switch zigbee mapping.
/// </summary>
public class WirelessSwitchDeviceMessage : ZigbeeDeviceMessage
{
	[JsonPropertyName("action")]
	public string Action { get; set; }
}
