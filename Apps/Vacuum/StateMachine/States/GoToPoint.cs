using System.Numerics;
using Serilog;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class GoToPoint : State<VacuumState, VacuumEvents, VacuumData>
{
	private readonly ILogger _logger;

	public GoToPoint(IStateTransitioner<VacuumEvents, VacuumData> stateTransitioner, ILogger loggerFactory)
		: base(VacuumState.GoToPoint, stateTransitioner)
	{
		_logger = loggerFactory.ForContext<GoToPoint>();
	}

	public override void Enter(VacuumEvents transitionEvent, VacuumData eventData)
	{
		_logger.Debug("Entered state {name}.", GetType().Name);

		var point = eventData.CleanBedroom switch
		{
			true => new Vector2(0, 0), // In front of bedroom door.
			false => new Vector2(33286, 32710) // Next to kitchen bin.
		};

		_logger.Debug("Go to point [{x}, {y}]", point.X, point.Y);

		if (!eventData.Debug)
		{
			// Move vacuum to point.
			eventData.Entity.CallService(
				"send_command", new
				{
					command = "app_goto_target",
					@params = new[]
					{
						point.X, point.Y
					}
				});
		}
	}

	public override void Exit(VacuumEvents transitionEvent) => _logger.Debug("Exiting state {name}.", GetType().Name);
}
