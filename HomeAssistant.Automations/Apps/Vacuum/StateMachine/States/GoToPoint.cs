using System.Numerics;
using Staty;

namespace HomeAssistant.Automations.Apps.Vacuum.StateMachine.States;

public class GoToPoint : State<VacuumState, VacuumEvents, VacuumData>
{
	public GoToPoint(IStateTransitioner<VacuumEvents, VacuumData> vacuumStateMachine)
		: base(VacuumState.GoToPoint, vacuumStateMachine)
	{
	}

	public override void Enter(VacuumEvents transitionEvent, VacuumData data)
	{
		var point = data.CleanBedroom switch
		{
			true => new Vector2(0, 0),			// In front of bedroom door.
			false => new Vector2(33286, 32710)	// Next to kitchen bin.
		};

		// Move vacuum to point.
		data.Entity.CallService(
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
