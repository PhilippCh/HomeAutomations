using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomeAutomations.Models;

public record Notification
{
	public string? Service { get; init; } = "ourphones";
	public string? Title { get; init; }
	public string? Template { get; init; }
	public string? Tag { get; init; }
	public string? Image { get; init; }
	public bool? Sticky { get; init; }
	public string? Url { get; init; }
	public IEnumerable<NotificationAction>? Actions { get; init; }

	public string RenderTemplate(params object[] args) => string.Format(Template ?? string.Empty, args);
}

public class NotificationAction
{
	[JsonPropertyName("action")]
	public string Action { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("destructive")]
	public bool Destructive { get; set; }

	[JsonPropertyName("uri")]
	public bool Uri { get; set; }
}
