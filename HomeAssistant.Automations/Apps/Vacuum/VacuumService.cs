using System;
using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Common;
using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps.Vacuum;

public class VacuumService
{
	private VacuumStateMachine? _stateMachine;
	private bool _cleanBedroom;

	private readonly Entity _entity;

	public VacuumService(IHaContext context)
	{
		_entity = new Entities(context).InputText.VacuumStateTest;
		_entity.StateChanges().Subscribe(OnEntityStateChanged);
	}

	public void StartWithBedroom() => Start(true);

	public void Start() => Start(false);

	private void Start(bool cleanBedroom)
	{
		_stateMachine = new VacuumStateMachine();
		_cleanBedroom = cleanBedroom;
	}

	private void OnEntityStateChanged(StateChange change)
	{
		var state = change.New?.State;

		if (state == null)
		{
			return;
		}

		var e = state switch
		{
			"cleaning" => VacuumEvents.Cleaning,
			"docked" => VacuumEvents.Docked,
			"idle" => VacuumEvents.Idle,
			"returning" => VacuumEvents.Returning,
			_ => VacuumEvents.Undefined
		};

		_stateMachine?.ExternalEvent(e, new VacuumData
		{
			Entity = _entity,
			CleanBedroom = _cleanBedroom
		});
	}
}
