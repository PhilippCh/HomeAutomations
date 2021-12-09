using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using IoC.StateMachine.Abstractions;
using IoC.StateMachine.Core;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAssistant.Automations.Apps.Vacuum.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddVacuumServices(this IServiceCollection services)
	{
		return services
			.AddSingleton<ISMService, SMService>()
			.AddTransient<IStateProcessor, StateProcessor>()
			.AddTransient<IStateMachine, VacuumStateMachine>()
			.AddTransient<VacuumStateMachine>()

			.AddSingleton<VacuumService>();
	}
}
