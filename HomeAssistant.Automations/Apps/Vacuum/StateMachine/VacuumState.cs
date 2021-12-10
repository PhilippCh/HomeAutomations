namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public enum VacuumState
{
	Idle,
	Clean,
	GoToPoint,

	GoToBin,
	GoToBedroom,
	ReturnToDock
}
