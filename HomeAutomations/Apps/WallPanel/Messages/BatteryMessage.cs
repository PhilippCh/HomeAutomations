using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.WallPanel.Messages;

public record BatteryMessage
{
	[JsonPropertyName("unit")]
	public string Unit { get; init; }

	[JsonPropertyName("value")]
	public double Value { get; init; }

	[JsonPropertyName("acPlugged")]
	public bool IsConnectedToAc { get; init; }

	[JsonPropertyName("usbPlugged")]
	public bool IsConnectedToUsb { get; init; }

	[JsonPropertyName("charging")]
	public bool IsCharging { get; init; }
}
