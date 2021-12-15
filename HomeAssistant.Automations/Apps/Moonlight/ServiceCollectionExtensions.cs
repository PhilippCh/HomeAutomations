using HomeAssistant.Automations.Apps.Vacuum;
using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Apps.Moonlight;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddMoonlightServices(this IServiceCollection services, IConfiguration config)
	{
		return services
			.Configure<MoonlightConfig>(config.GetSection("HomeAssistant.Automations:Moonlight"));
	}
}
