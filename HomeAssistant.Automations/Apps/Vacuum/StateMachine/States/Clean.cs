﻿using Serilog;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class Clean: State<VacuumState, VacuumEvents, VacuumData>
{
	private readonly ILogger _logger;

	public Clean(IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner, ILogger loggerFactory)
		: base(VacuumState.Clean, stateTransitioner)
	{
		_logger = loggerFactory.ForContext<Clean>();
	}

	public override void Enter(VacuumEvents transitionEvent, VacuumData eventData) => _logger.Debug("Entered state {name}.", GetType().Name);

	public override void Exit(VacuumEvents transitionEvent) => _logger.Debug("Exiting state {name}.", GetType().Name);
}
