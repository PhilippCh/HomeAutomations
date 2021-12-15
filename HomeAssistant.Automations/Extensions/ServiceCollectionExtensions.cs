using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Apps.Moonlight;
using HomeAssistant.Automations.Apps.Vacuum;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutomationServices(this IServiceCollection services, IConfiguration config)
	{
		return services
			.Configure<MqttConfig>(config.GetSection("MQTT"))

			.AddSingleton<NotificationService>()
			.AddSingleton<MqttService>()
			.AddTransient<PingService>()
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>))

			.AddMoonlightServices(config)
			.AddVacuumServices(config)
			.AddKitchenLightServices(config);
	}
}
