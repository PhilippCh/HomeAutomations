using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using Staty;

public class Idle : State<VacuumState, VacuumEvents, VacuumData>
{
	public Idle(IStateTransitioner<VacuumEvents, VacuumData> vacuumStateMachine)
		: base(VacuumState.Idle, vacuumStateMachine)
	{
	}
}
