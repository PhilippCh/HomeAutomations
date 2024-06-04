using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.StudyAutomations;

[Focus]
public class StudyAutomations(
	BaseAutomationDependencyAggregate<StudyAutomations, StudyAutomationsConfig> aggregate,
	TriggerRepository triggerRepository) : BaseAutomation<StudyAutomations, StudyAutomationsConfig>(aggregate)
{
	private bool _isForceDeskLampStateOn; // Determines whether force mode is on.
	private bool _forceDeskLampState; // Determines which mode the lamp is forced to.
	private bool _lastTriggerState; // Used when resetting lamp state to last automatic trigger state.

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		RegisterSpeakerTrigger();
		RegisterDeskLampTrigger();

		return Task.CompletedTask;
	}

	private void RegisterDeskLampTrigger()
	{
		var deskLampTrigger = triggerRepository.GetTrigger(Config.DeskLampTriggerId);

		if (deskLampTrigger == null)
		{
			Logger.Error("No trigger found for desk lamp automation");

			return;
		}

		var deskLampTriggerObserver = deskLampTrigger
			.AsObservable()
			.Subscribe(
				x =>
				{
					_lastTriggerState = x;
					ToggleDeskLamp(x);
				});
		Disposables.Add(deskLampTriggerObserver);

		var deskLampSwitchObserver = Config.DeskLamp.SwitchAction
			.StateChanges()
			.Subscribe(
				s =>
				{
					Action action = WirelessSwitchActions.Map(s.New?.State) switch
					{
						ButtonAction.Single => ToggleForceDeskLamp,
						ButtonAction.Double => ResetForceDeskLamp,
						_ => () => {} // Do nothing.
					};

					action();
				});
		Disposables.Add(deskLampSwitchObserver);
	}

	private void RegisterSpeakerTrigger()
	{
		var speakerTrigger = triggerRepository.GetTrigger(Config.SpeakerTriggerid);

		if (speakerTrigger == null)
		{
			Logger.Error("No trigger found for computer speaker automation");

			return;
		}

		var speakerTriggerObserver = speakerTrigger
			.AsObservable()
			.Subscribe(
				x =>
				{
					Logger.Information("Setting speakers to {State}", x);
					Config.Speaker.SetState(x);
				});
		Disposables.Add(speakerTriggerObserver);
	}

	private void ToggleForceDeskLamp()
	{
		_isForceDeskLampStateOn = true;
		_forceDeskLampState = !Config.DeskLamp.Entity.IsOn();
		ToggleDeskLamp(_forceDeskLampState);
	}

	private void ResetForceDeskLamp()
	{
		_isForceDeskLampStateOn = false;
		ToggleDeskLamp(_lastTriggerState);
	}

	private void ToggleDeskLamp(bool isOn)
	{
		var state = _isForceDeskLampStateOn ? _forceDeskLampState : isOn;

		Logger.Information("Setting desk lamp to {State}", state);
		Config.DeskLamp.Entity.SetState(state);
	}
}
