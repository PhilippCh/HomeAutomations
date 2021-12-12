using Serilog;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class ReturnToDock: State<VacuumState, VacuumEvents, VacuumData>
{
	private readonly ILogger _logger;

	public ReturnToDock(IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner, ILogger loggerFactory)
		: base(VacuumState.ReturnToDock, stateTransitioner)
	{
		_logger = loggerFactory.ForContext<Idle>();
	}

	public override void Enter(VacuumEvents transitionEvent, VacuumData eventData) => _logger.Debug("Entered state {name}.", GetType().Name);

	public override void Exit(VacuumEvents transitionEvent) => _logger.Debug("Exiting state {name}.", GetType().Name);
}
