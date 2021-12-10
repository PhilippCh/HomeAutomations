using HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public class VacuumStateProvider : StateProvider<State<VacuumState, VacuumEvents, VacuumData>, VacuumState, VacuumEvents, VacuumData>
{
	protected override State<VacuumState, VacuumEvents, VacuumData>[] GetStates(IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner)
	{
		return new State<VacuumState, VacuumEvents, VacuumData>[]
		{
			new Idle(stateTransitioner),
			new Clean(stateTransitioner),
			new GoToPoint(stateTransitioner)
		};
	}
}
