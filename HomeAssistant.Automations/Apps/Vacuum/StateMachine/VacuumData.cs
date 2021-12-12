using HomeAssistant.Automations.Models;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public class VacuumData : StateMachineEntityData
{
	public bool CleanBedroom { get; set; }
}
