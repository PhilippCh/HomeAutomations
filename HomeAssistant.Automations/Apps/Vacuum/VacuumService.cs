using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using HomeAssistant.Automations.Services;
using IoC.StateMachine.Core.Classes;

namespace HomeAssistant.Automations.Apps.Vacuum;

public class VacuumService
{
	private VacuumStateMachine? _stateMachine;

	private readonly StateMachineService _stateMachineService;

	public VacuumService(StateMachineService stateMachineService)
	{
		_stateMachineService = stateMachineService;
	}

	public void StartWithBedroom() => Start(true);

	public void Start() => Start(false);

	private void Start(bool cleanBedroom)
	{
		var parameters = new SMParametersCollection { { "cleanBedroom", cleanBedroom } };

		if (_stateMachine == null)
		{
			_stateMachine = _stateMachineService.Start<VacuumStateMachine>(VacuumStateMachine.GetDefinition(), parameters);
		}

		_stateMachineService.Push(_stateMachine, parameters);
	}
}
