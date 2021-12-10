using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Apps.Vacuum.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddVacuumServices(this IServiceCollection services) =>
		services
			.AddSingleton<VacuumService>();
}
