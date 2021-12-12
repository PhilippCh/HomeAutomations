using HomeAssistant.Automations.Services;
using Serilog;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class WaitForAction : State<VacuumState, VacuumEvents, VacuumData>
{
	private readonly NotificationService _notificationService;
	private readonly VacuumNotificationConfig _notificationConfig;
	private readonly ILogger _logger;

	public WaitForAction(
		IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner,
		ILogger loggerFactory,
		NotificationService notificationService,
		VacuumNotificationConfig notificationConfig)
		: base(VacuumState.WaitForAction, stateTransitioner)
	{
		_notificationService = notificationService;
		_notificationConfig = notificationConfig;
		_logger = loggerFactory.ForContext<WaitForAction>();
	}

	public override void Enter(VacuumEvents transitionEvent, VacuumData eventData)
	{
		_logger.Debug("Entered state {name}.", GetType().Name);

		var notification = eventData.CleanBedroom switch
		{
			true => _notificationConfig.CleanBedroom,
			false => _notificationConfig.EmptyBin
		};

		_notificationService.SendNotification(notification);
	}

	public override void Exit(VacuumEvents transitionEvent) => _logger.Debug("Exiting state {name}.", GetType().Name);
}
