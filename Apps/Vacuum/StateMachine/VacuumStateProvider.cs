using HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;
using HomeAssistant.Automations.Services;
using HomeAutomations.Services;
using Microsoft.Extensions.Options;
using Serilog;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine;

public class VacuumStateProvider : StateProvider<State<VacuumState, VacuumEvents, VacuumData>, VacuumState, VacuumEvents, VacuumData>
{
	private readonly NotificationService _notificationService;
	private readonly IOptionsMonitor<VacuumConfig> _config;
	private readonly ILogger _loggerFactory;

	public VacuumStateProvider(NotificationService notificationService, IOptionsMonitor<VacuumConfig> config, ILogger loggerFactory)
	{
		_notificationService = notificationService;
		_config = config;
		_loggerFactory = loggerFactory;
	}

	protected override State<VacuumState, VacuumEvents, VacuumData>[] GetStates(IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner)
	{
		return new State<VacuumState, VacuumEvents, VacuumData>[]
		{
			new Idle(stateTransitioner, _loggerFactory),
			new Clean(stateTransitioner, _loggerFactory),
			new GoToPoint(stateTransitioner, _loggerFactory),
			new WaitForAction(stateTransitioner, _loggerFactory, _notificationService, _config.CurrentValue.Notifications),
			new ReturnToDock(stateTransitioner, _loggerFactory)
		};
	}
}
