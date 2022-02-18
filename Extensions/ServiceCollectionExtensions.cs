using HomeAssistant.Automations.Services;
using HomeAutomations.Apps.Scales.KitchenScale;
using HomeAutomations.Apps.Vacuum;
using HomeAutomations.Models;
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
			.AddTransient<PingService>()
			.AddTransient(typeof(BaseServiceDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>));

		VacuumReminder.AddServices(services, config);
		KitchenScale.AddServices(services, config);

		return services;
	}
}
