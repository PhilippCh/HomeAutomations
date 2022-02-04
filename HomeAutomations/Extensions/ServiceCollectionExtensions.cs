﻿using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Apps.Moonlight;
using HomeAssistant.Automations.Apps.Scales.KitchenScale;
using HomeAssistant.Automations.Apps.TrashReminder;
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
		services
			.Configure<MqttConfig>(config.GetSection("MQTT"))
			.AddSingleton<MqttService>()
			.AddScoped<NotificationService>()
			.AddTransient<PingService>()
			.AddTransient(typeof(BaseServiceDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>));

		KitchenLight.AddServices(services, config);
		MoonlightGameLauncher.AddServices(services, config);
		TrashReminder.AddServices(services, config);
		VacuumReminder.AddServices(services, config);
		KitchenScale.AddServices(services, config);

		return services;
	}
}
