using Staty;
using Staty.Configuration;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public class VacuumStateMachine : StateMachine<State<VacuumState, VacuumEvents, VacuumData>, VacuumState, VacuumEvents, VacuumData>
{
	public VacuumStateMachine()
		: base(VacuumStateMachineConfiguration, new VacuumStateProvider(), VacuumState.Idle, VacuumState.ReturnToDock)
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

			// Build.
			.Build();
}
