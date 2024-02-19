using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Entities.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;

namespace HomeAutomations.Apps.StudyAutomations;

[Focus]
public class StudyAutomations : BaseAutomation<StudyAutomations, StudyAutomationsConfig>
{
	private DateTimeOffset? _deskLampStartTime;
	private bool _isForceDeskLampStateOn; // Determines whether force mode is on.
	private bool _forceDeskLampState; // Determines which mode the lamp is forced to.

	public StudyAutomations(BaseAutomationDependencyAggregate<StudyAutomations, StudyAutomationsConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		RegisterSpeakerTrigger();
		RegisterDeskLampTrigger();

		return Task.CompletedTask;
	}

	private void RegisterDeskLampTrigger()
	{
		var deskLampTrigger = new AndTrigger(
			new OrTrigger(
				new AndTrigger(
					Config.Computers.DesktopPhilipp.NetworkSensor.ToObservableState(),
					Config.Computers.DesktopPhilipp.UnlockedSensor.ToObservableState()
				).GetTrigger(),
				new AndTrigger(
					Config.Computers.LaptopEnbw.NetworkSensor.ToObservableState(),
					Config.Computers.LaptopEnbw.UnlockedSensor.ToObservableState()
				).GetTrigger()
			).GetTrigger(),
			new BrightnessTrigger(Config.DeskLamp.TriggerConfig).GetTrigger());

		deskLampTrigger.GetTrigger().Subscribe(
			x =>
			{
				Logger.Information("DesktopPhilipp N {Network} U {Unlocked} | LaptopEnBW N {Network} U {Unlocked}",
					Config.Computers.DesktopPhilipp.NetworkSensor.State,
					Config.Computers.DesktopPhilipp.UnlockedSensor.State,
					Config.Computers.LaptopEnbw.NetworkSensor.State,
					Config.Computers.LaptopEnbw.UnlockedSensor.State);

				if (x != null)
				{
					ToggleDeskLamp(x.Value);
				}
			});

		Config.DeskLamp.SwitchAction.StateChanges()
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
	}

	private void RegisterSpeakerTrigger()
	{
		new MultiBinarySwitchTrigger(
				new[]
				{
					Config.Computers.DesktopPhilipp.NetworkSensor,
					Config.Computers.LaptopEnbw.NetworkSensor
				})
			.GetTrigger()
			.Subscribe(
				x =>
				{
					if (x != null)
					{
						Logger.Information("Setting speakers to {State}", x);
						Config.Speaker.SetState(x.Value);
					}
				});
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
		var state = _isForceDeskLampStateOn ? _forceDeskLampState : isOn;

		Logger.Information("Setting desk lamp to {State}", state);
		Config.DeskLamp.Entity.SetState(state);

		if (state)
		{
			_deskLampStartTime = DateTimeOffset.Now;
		}
	}
}
