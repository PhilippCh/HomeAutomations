using System;
using System.Threading.Tasks;
using EmbedIO;
using EmbedIO.Routing;
using EmbedIO.WebApi;
using NetDaemon.HassModel.Common;

namespace HomeAssistant.Automations.Apps.WebhookServer;

public class WebhookController : WebApiController
{
	public WebhookController(IHaContext context)
	{

	}

	[Route(HttpVerbs.Get, "/")]
	public async Task Get()
	{
		var data = await HttpContext.GetRequestBodyAsStringAsync();
		Console.WriteLine(data);
	}
}
