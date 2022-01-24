using HomeAssistant.Automations.Models;

namespace HomeAssistant.Automations.Apps.WebhookServer;

public class WebhookServerConfig : Config
{
	public string BaseUrl { get; set; }
}
