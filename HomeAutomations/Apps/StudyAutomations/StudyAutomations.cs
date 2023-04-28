using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.StudyAutomations.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;

namespace HomeAutomations.Apps.StudyAutomations;

[Focus]
public class StudyAutomations : BaseAutomation<StudyAutomations, StudyAutomationsConfig>
{
	private InputBooleanEntity _deskLampOverrideSwitch;

	public StudyAutomations(BaseAutomationDependencyAggregate<StudyAutomations, StudyAutomationsConfig> aggregate)
		: base(aggregate)
	{
		_deskLampOverrideSwitch = Entities.InputBoolean.OverrideDeskLamp;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		var computerTrigger = new MultiBinarySwitchTrigger(Config.Computers).GetTrigger();
		computerTrigger.Subscribe(
			x =>
			{
				Logger.Information("Setting speakers to {State}", x);
				Config.Speaker.SetState(x);
			});

		Observable.CombineLatest(
				new BrightnessTrigger(Config.DeskLampTriggerConfig).GetTrigger(),
				new MultiBinarySwitchTrigger(Config.Computers).GetTrigger()
			)
			.Subscribe(x => ToggleDeskLamp(x.All(y => y)));
		Entities.Sensor.StudyDeskLampSwitchAction.StateChanges().Subscribe(
			s =>
			{
				var action = WirelessSwitchActions.Map(s.New?.State);

				if (action == ButtonAction.Single)
				{
					_deskLampOverrideSwitch.Toggle();
				}
			});
		_deskLampOverrideSwitch.StateChanges().Subscribe(_ => ToggleDeskLamp(_deskLampOverrideSwitch.IsOn()));

		return Task.CompletedTask;
	}

	private void ToggleForceDeskLamp()
	{
		_isForceDeskLampStateOn = true;
		_forceDeskLampState = !_forceDeskLampState;
		ToggleDeskLamp(_forceDeskLampState);
	}

	private void ResetForceDeskLamp()
	{
		_isForceDeskLampStateOn = false;
		ToggleDeskLamp(false);
	}

	private void ToggleDeskLamp(bool isOn)
	{
		var state = isOn || _deskLampOverrideSwitch.IsOn();

		Logger.Information("Setting desk lamp to {State}", state);
		Config.DeskLamp.SetState(state);
	}
}
