using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Models;

public abstract class StateMachineEntityData
{
	public Entity Entity { get; set; }
	public bool Debug { get; set; }
}
