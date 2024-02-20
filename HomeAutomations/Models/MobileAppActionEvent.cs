using System.Text.Json.Serialization;

namespace HomeAutomations.Models;

public class MobileAppActionEvent
{
	[JsonPropertyName("actionID")]
	public string ActionId { get; set; }

	[JsonPropertyName("actionName")]
	public string ActionName { get; set; }

	[JsonPropertyName("sourceDeviceID")]
	public string DeviceId { get; set; }

	[JsonPropertyName("sourceDeviceName")]
	public string DeviceName { get; set; }
}
