using System;
using System.Linq;
using System.Reflection;
using HomeAssistant.Automations.Apps.CalorieCounter;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Apps.Moonlight;
using HomeAssistant.Automations.Apps.Scales.KitchenScale;
using HomeAssistant.Automations.Apps.TrashReminder;
using HomeAssistant.Automations.Apps.Vacuum;
using HomeAssistant.Automations.Attributes;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Services;
using HomeAutomations.Apps.Scales.KitchenScale;
using HomeAutomations.Apps.Vacuum;
using HomeAutomations.Models;
using HomeAutomations.Services;
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

		var appTypes = Assembly.GetExecutingAssembly()
			.GetTypes()
			.Select(t => (Type: t, Attribute: t.GetCustomAttribute<HomeAutomationAttribute>()))
			.Where(t => !t.Type.IsGenericType || t.Type.GetGenericTypeDefinition() != typeof(BaseAutomation<,>))
			.Where(t => t.Attribute != null)
			.Select(t => (App: t.Type, Config: t.Type.BaseType!.GenericTypeArguments[1]));

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
