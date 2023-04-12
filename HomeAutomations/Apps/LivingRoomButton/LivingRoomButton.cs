using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LivingRoomButton;

public class LivingRoomButton : BaseAutomation<LivingRoomButton, LivingRoomButtonConfig>
{
	private IDisposable? _brightnessLoopObserver;

	public LivingRoomButton(BaseAutomationDependencyAggregate<LivingRoomButton, LivingRoomButtonConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Config.Button.StateChanges().Subscribe(s => OnButtonPressed(s.New?.State));

		return Task.CompletedTask;
	}

	private void OnButtonPressed(string? state)
	{
		var buttonAction = WirelessSwitchActions.Map(state);
		Action action = buttonAction switch
		{
			ButtonAction.Single => () => Config.StandardLamp.Toggle(),
			ButtonAction.On => () => Config.StandardLamp.TurnOn(),
			ButtonAction.Off => () => Config.StandardLamp.TurnOff(),
			ButtonAction.BrightnessUp => () => _brightnessLoopObserver = StartBrightnessLoop(1),
			ButtonAction.BrightnessDown => () => _brightnessLoopObserver = StartBrightnessLoop(-1),
			ButtonAction.BrightnessStop => () => _brightnessLoopObserver?.Dispose(),
			_ => () => {} // Do nothing
		};

		action();
	}

	private IDisposable StartBrightnessLoop(int increment)
	{
		return Observable.Interval(TimeSpan.FromMilliseconds(100))
			.Subscribe(
				_ =>
				{
					var currentBrightness = Config.StandardLamp.Attributes?.Brightness ?? 254;
					Config.StandardLamp.TurnOn(brightness: (long) (currentBrightness + increment));
				});
	}
}
