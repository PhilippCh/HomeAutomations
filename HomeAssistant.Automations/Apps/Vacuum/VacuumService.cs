using System;
using System.Reactive.Linq;
using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NetDaemon.HassModel.Common;
using NetDaemon.HassModel.Entities;
using Serilog;

namespace HomeAssistant.Automations.Apps.Vacuum;

public class VacuumService
{
	private readonly IServiceProvider _services;
	private readonly IOptionsMonitor<VacuumConfig> _config;
	private VacuumStateMachine? _stateMachine;
	private bool _cleanBedroom;

	private readonly Entity _entity;
	private readonly ILogger _logger;

	public VacuumService(IHaContext context, IServiceProvider services, IOptionsMonitor<VacuumConfig> config, ILogger loggerFactory)
	{
		_services = services;
		_config = config;
		_logger = loggerFactory.ForContext<VacuumService>();

		_entity = new Entities(context).InputText.VacuumStateTest;
		_entity.StateChanges().Subscribe(OnEntityStateChanged);
	}

	public void StartWithBedroom() => Start(true);

	public void Start() => Start(false);

	private void Start(bool cleanBedroom)
	{
		_stateMachine = _services.GetRequiredService<VacuumStateMachine>();
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
			"idle" => VacuumEvents.Idle,
			"returning" => VacuumEvents.Returning,
			_ => VacuumEvents.Undefined
		};

		_logger.Debug("State machine external event {event}", e);

		_stateMachine?.ExternalEvent(
			e, new VacuumData
			{
				Entity = _entity,
				Debug = _config.CurrentValue.Debug,
				CleanBedroom = _cleanBedroom
			});
	}
}
