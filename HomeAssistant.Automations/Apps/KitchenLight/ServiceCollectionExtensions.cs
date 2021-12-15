using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Apps.KitchenLight;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddKitchenLightServices(this IServiceCollection services, IConfiguration config)
	{
		return services
			.Configure<KitchenLightConfig>(config.GetSection("HomeAssistant.Automations:KitchenLight"));
	}
}
