using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HomeAssistant.Automations.Models;

public class Notification
{
	public string Service { get; set; } = "notify";
	public string Title { get; set; }
	public string Template { get; set; }
	public string Tag { get; set; }
	public IEnumerable<NotificationAction> Actions { get; set; }
}

public class NotificationAction
{
	[JsonPropertyName("action")]
	public string Action { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("destructive")]
	public bool Destructive { get; set; }
}
