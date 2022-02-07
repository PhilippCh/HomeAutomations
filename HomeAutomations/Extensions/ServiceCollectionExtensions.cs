using System;
using HomeAssistant.Automations.Apps.CalorieCounter;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Apps.Moonlight;
using HomeAssistant.Automations.Apps.Scales.KitchenScale;
using HomeAssistant.Automations.Apps.TrashReminder;
using HomeAssistant.Automations.Apps.Vacuum;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAssistant.Automations.Extensions;

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
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>));

		var appTypes = new (Type App, Type Config)[]
		{
			(typeof(KitchenLight), typeof(KitchenLightConfig)),
			(typeof(KitchenScale), typeof(KitchenScaleConfig)),
			(typeof(CalorieCounter), typeof(CalorieCounterConfig)),
			(typeof(MoonlightGameLauncher), typeof(MoonlightConfig)),
			(typeof(TrashReminder), typeof(TrashReminderConfig)),
			(typeof(VacuumReminder), typeof(VacuumConfig))
		};

		foreach (var (appType, configType) in appTypes)
		{
			typeof(OptionsConfigurationServiceCollectionExtensions)
				.GetMethod("Configure", new[] { typeof(IServiceCollection), typeof(IConfiguration) })
				?.MakeGenericMethod(configType)
				.Invoke(null, new object[] { services, config.GetSection($"HomeAutomations:{appType.Name}") });
		}

		VacuumReminder.AddServices(services, config);
		KitchenScale.AddServices(services, config);

		return services;
	}
}
