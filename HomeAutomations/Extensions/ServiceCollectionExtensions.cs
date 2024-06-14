﻿using System.Linq;
using System.Reflection;
using HomeAutomations.Apps.ComputerSwitches;
using HomeAutomations.Apps.IntelligentShoppingList;
using HomeAutomations.Attributes;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
using HomeAutomations.Common.Services.Bluetooth;
using HomeAutomations.Common.Services.Bluetooth.Commands;
using HomeAutomations.Common.Services.Graph;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Models;
using HomeAutomations.Services;
using HomeAutomations.Services.LLM;
using HomeAutomations.Services.Weather;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace HomeAutomations.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutomationServices(this IServiceCollection services, Assembly assembly, IConfiguration config)
	{
		services
			.Configure<MqttConfig>(config.GetSection("MQTT"))
			.AddSingleton<MqttService>()
			.AddScoped<WakeOnLanService>()
			.AddScoped<INotificationService, NotificationService>()
			.AddScoped<IClockService, ClockService>()
			.AddTransient<IWeatherService, WeatherService>()
			.AddTransient<ActionSequencerService>()
			.AddSingleton<EntityStatePriorityManager>()
			.AddScoped<TriggerRepository>()
			.AddTransient<PingService>()

			// Bluetooth
			.Configure<BluetoothServiceConfig>(config.GetSection("Bluetooth"))
			.AddSingleton<BluetoothService>()
			.AddTransient<AtCommandService>()

			// Weather
			.Configure<WeatherServiceConfig>(config.GetSection("Weather"))

			// Intelligent shopping list
			.Configure<OpenAiConfig>(config.GetSection("OpenAi"))
			.AddScoped<ILlmService, OpenAiService>()
			.AddMicrosoftGraphClient(config.GetSection("Graph"))

			.Configure<TriggerRepositoryConfig>(config.GetSection("TriggerRepository"))
			.AddTransient(typeof(BaseServiceDependencyAggregate<>))
			.AddTransient(typeof(BaseServiceDependencyAggregate<,>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>))
			.AddAutomationDependencies(assembly, config);

		// To provide the Nuki Bridge API callback controller.
		services.AddControllers();

		services
			.AddHttpClient<ComputerSwitches>()
			.AddTransientHttpErrorPolicy(
				x => x.WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(3, retryAttempt))));

		return services;
	}

	private static IServiceCollection AddAutomationDependencies(this IServiceCollection services, Assembly assembly, IConfiguration config)
	{
		var apps = assembly.GetTypes().Where(t => t.GetCustomAttribute<HomeAutomationAttribute>() != null);

		foreach (var app in apps)
		{
			var addServicesMethod = app.GetMethod("AddServices");
			addServicesMethod?.Invoke(null, new object?[] { services, config });
		}

		return services;
	}
}
