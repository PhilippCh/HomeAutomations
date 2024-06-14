using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
using HomeAutomations.Common.Services.Graph;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Common.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddMqttService(this IServiceCollection services, IConfiguration config)
	{
		return services
			.Configure<MqttConfig>(config.GetSection("MQTT"))
			.AddSingleton<MqttService>();
	}

	public static IServiceCollection AddMicrosoftGraphClient(this IServiceCollection services, IConfigurationSection config)
	{
		return services
			.Configure<MicrosoftGraphConfig>(config)
			.AddSingleton<GraphTodoClient>();
	}
}
