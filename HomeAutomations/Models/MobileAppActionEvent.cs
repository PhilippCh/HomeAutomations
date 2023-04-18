using System.Text.Json.Serialization;

namespace HomeAutomations.Models;

public class MobileAppActionEvent
{
	[JsonPropertyName("actionID")]
	public string ActionId { get; set; }

	[JsonPropertyName("actionName")]
	public string ActionName { get; set; }
}
