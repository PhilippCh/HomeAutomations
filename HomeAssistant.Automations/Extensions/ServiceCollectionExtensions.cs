using HomeAssistant.Automations.Apps.Vacuum.Extensions;
using HomeAssistant.Automations.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutomationServices(this IServiceCollection services)
	{
		return services
			.AddSingleton<NotificationService>()
			.AddVacuumServices();
	}
}
