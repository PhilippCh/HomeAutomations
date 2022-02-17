using HomeAssistant.Automations.Services;
using HomeAutomations.Apps.Scales.KitchenScale;
using HomeAutomations.Apps.Vacuum;
using HomeAutomations.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutomationServices(this IServiceCollection services, IConfiguration config)
	{
		services
			.Configure<MqttConfig>(config.GetSection("MQTT"))
			.AddSingleton<MqttService>()
			.AddScoped<NotificationService>()
			.AddTransient<PingService>();

		VacuumReminder.AddServices(services, config);
		KitchenScale.AddServices(services, config);

		return services;
	}
}
