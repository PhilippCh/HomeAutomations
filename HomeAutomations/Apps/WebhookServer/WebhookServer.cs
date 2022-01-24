using System;
using System.Diagnostics;
using EmbedIO;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;

namespace HomeAssistant.Automations.Apps.WebhookServer;

[Focus]
[NetDaemonApp]
public class WebhookServer : BaseAutomation<WebhookServer, WebhookServerConfig>
{
	private WebServer _server;

	public WebhookServer(BaseAutomationDependencyAggregate<WebhookServer, WebhookServerConfig> aggregate)
		: base(aggregate)
	{
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.Configure<WebhookServerConfig>(config.GetSection("HomeAutomations:WebhookServer"));

	protected override void Start()
	{
		_server = CreateWebServer(Config.BaseUrl);
		_server.RunAsync();
	}

	private WebServer CreateWebServer(string url)
	{
		var server = new WebServer(
				o => o
					.WithUrlPrefix(url)
					.WithMode(HttpListenerMode.EmbedIO))
			.WithLocalSessionManager()
			.WithWebApi("/webhook", m => m.RegisterController(() => new WebhookController(Context)));

		server.StateChanged += (s, e) => Logger.Information("WebhookServer New State - {newState}", e.NewState);

		return server;
	}
}
