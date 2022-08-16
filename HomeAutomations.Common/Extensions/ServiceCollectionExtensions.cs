using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services;
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
}
