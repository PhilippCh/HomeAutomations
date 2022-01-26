using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models.DeviceMessages;

/// <summary>
/// Generic zigbee scale device mapping. Provides value and unit.
/// </summary>
public class ScaleDeviceMessage : ZigbeeDeviceMessage
{
	[JsonPropertyName("connected")]
	public bool IsConnected { get; set; }

	[JsonPropertyName("value")]
	public int Value { get; set; }

	[JsonPropertyName("unit")]
	public string Unit { get; set; }
}
