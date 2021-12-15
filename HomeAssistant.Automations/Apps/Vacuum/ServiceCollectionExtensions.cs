using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Apps.Vacuum;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddVacuumServices(this IServiceCollection services, IConfiguration config)
	{
		return services
			.Configure<VacuumConfig>(config.GetSection("HomeAssistant.Automations:Vacuum"))

			.AddTransient<VacuumStateMachine>()
			.AddTransient<VacuumStateProvider>()
			.AddSingleton<VacuumService>();
	}
}
