using HomeAssistant.Automations.Models;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public enum CleaningState
{
	Apartment,
	Bedroom
}

public class VacuumData : StateMachineEntityData
{
	public bool CleanBedroom { get; set; }
	public CleaningState CleaningState { get; set; }
}
