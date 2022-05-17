using System.Linq;
using System.Reflection;
using HomeAutomations.Apps.ComputerSwitches;
using HomeAutomations.Apps.Scales.KitchenScale;
using HomeAutomations.Apps.Scales.KitchenScale.Fddb;
using HomeAutomations.Apps.Vacuum;
using HomeAutomations.Attributes;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Services;
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
			.Configure<HarmonyHubConfig>(config.GetSection("HarmonyHub"))
			.AddSingleton<MqttService>()
			.AddSingleton<HarmonyHubService>()
			.AddScoped<NotificationService>()
			.AddTransient<PingService>()
			.AddTransient(typeof(BaseServiceDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<>))
			.AddTransient(typeof(BaseAutomationDependencyAggregate<,>))
			.AddAutomationDependencies(assembly, config);

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
