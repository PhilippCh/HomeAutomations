namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public enum VacuumEvents
{
	Undefined, // Fallback for unimplemented HA entity states.

	// HA Entity states.
	Cleaning,
	Docked,
	Idle,
	Returning,

	// Internal states.
	GoToBin,
	GoToBedroom,
}
