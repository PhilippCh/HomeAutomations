using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomeAutomations.Models;

public record Notification
{
	public string? Service { get; init; } = "notify";
	public string? Title { get; init; }
	public string? Template { get; init; }
	public string? Tag { get; init; }
	public string? Image { get; init; }
	public bool? Sticky { get; init; }
	public IEnumerable<NotificationAction>? Actions { get; init; }

	public Notification() {}

	public Notification(Notification template, object[]? templateArgs = null)
	{
		Service = template.Service;
		Title = template.Title;
		Template = template.Template;
		Tag = template.Tag;
		Image = template.Image;
		Actions = JsonSerializer.Deserialize<IEnumerable<NotificationAction>>(JsonSerializer.Serialize(template.Actions));

		if (templateArgs != null)
		{
			Template = string.Format(Template ?? string.Empty, templateArgs);
		}
	}
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
