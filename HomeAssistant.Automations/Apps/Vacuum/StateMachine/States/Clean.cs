using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class Clean: State<VacuumState, VacuumEvents, VacuumData>
{
	public Clean(IStateTransitioner<VacuumEvents, VacuumData> vacuumStateMachine)
		: base(VacuumState.Clean, vacuumStateMachine)
	{
	}
}
