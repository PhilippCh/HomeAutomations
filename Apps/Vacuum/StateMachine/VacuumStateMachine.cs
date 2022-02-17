using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using Staty;
using Staty.Configuration;

namespace HomeAutomations.Apps.Vacuum.StateMachine;

public class VacuumStateMachine : StateMachine<State<VacuumState, VacuumEvents, VacuumData>, VacuumState, VacuumEvents, VacuumData>
{
	public VacuumStateMachine(VacuumStateProvider stateProvider)
		: base(VacuumStateMachineConfiguration, stateProvider, VacuumState.Idle, VacuumState.ReturnToDock)
	{
	}

	private static IStateMachineConfiguration<VacuumState, VacuumEvents, VacuumData> VacuumStateMachineConfiguration =>
		new StateMachineConfigurationBuilder<VacuumState, VacuumEvents, VacuumData>()
			// Idle transitions.
			.WhenIn(VacuumState.Idle)
			.AndReceived(VacuumEvents.Cleaning)
			.GoTo(VacuumState.Clean)

			// Clean transitions.
			.WhenIn(VacuumState.Clean)
			.AndReceived(VacuumEvents.Returning)
			.GoTo(VacuumState.GoToPoint)

			// GoToPoint transitions.
			.WhenIn(VacuumState.GoToPoint)
			.AndReceived(VacuumEvents.Idle)
			.GoTo(VacuumState.WaitForAction)

			// WaitForAction transitions.
			.WhenIn(VacuumState.WaitForAction)
			.AndReceived(VacuumEvents.Cleaning)
			.GoTo(VacuumState.Clean)
			.WhenIn(VacuumState.WaitForAction)
			.AndReceived(VacuumEvents.Returning)
			.GoTo(VacuumState.ReturnToDock)

			// No ReturnToDock transitions because it is the final state.

			// Build.
			.Build();
}
