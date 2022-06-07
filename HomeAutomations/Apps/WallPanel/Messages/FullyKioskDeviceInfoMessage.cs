using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.WallPanel.Messages;

public record FullyKioskDeviceInfoMessage
{
	[JsonPropertyName("batteryLevel")]
	public int BatteryLevel { get; init; }

	[JsonPropertyName("isPlugged")]
	public bool IsPlugged { get; init; }
}
