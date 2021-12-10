using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public class VacuumData
{
	public Entity Entity { get; set; }
	public bool CleanBedroom { get; set; }
}
