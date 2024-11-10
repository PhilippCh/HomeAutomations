using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Buttons;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.LivingRoomButton;

public class LivingRoomButton : BaseAutomation<LivingRoomButton, LivingRoomButtonConfig>
{
	private const int _maxBrightness = 254;

	private IDisposable? _brightnessLoopObserver;

	public LivingRoomButton(BaseAutomationDependencyAggregate<LivingRoomButton, LivingRoomButtonConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Config.Button.StateChanges().Subscribe(s => OnButtonPressed(s.New?.State));

		Config.Button.StateChanges()
			.Where(x => x.New?.IsValidButtonState() ?? false)
			.Buffer(() => Config.Button.StateChanges().Throttle(TimeSpan.FromMilliseconds(500)))
			.Select(x => x.Select(y => y.New?.IsOn()))
			.Where(x => ButtonCombinationDecoder.IsButtonCombination(x, ButtonCombination.Reset) == true)
			.Subscribe(_ => ResetBrightness());

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
			ButtonAction.BrightnessUp => () => _brightnessLoopObserver = StartBrightnessLoop(Config.BrightnessIncrement),
			ButtonAction.BrightnessDown => () => _brightnessLoopObserver = StartBrightnessLoop(-Config.BrightnessIncrement),
			ButtonAction.BrightnessStop => () => _brightnessLoopObserver?.Dispose(),
			_ => () => {} // Do nothing
		};

		action();
	}

	private IDisposable StartBrightnessLoop(int increment)
	{
		return Observable.Interval(TimeSpan.FromMilliseconds(Config.BrightnessIncrementTimeoutMs))
			.Subscribe(
				_ =>
				{
					var currentBrightness = Config.StandardLamp.Attributes?.Brightness ?? _maxBrightness;
					var brightness = (long) Math.Clamp(currentBrightness + increment, 0, _maxBrightness);
					var brightnessPct = (int) Math.Round(brightness / (double) _maxBrightness * 100);

					Config.StandardLamp.TurnOn(brightnessPct: brightnessPct);
				});
	}

	private void ResetBrightness() => Config.StandardLamp.TurnOn(brightnessPct: 100, effect: LightEffects.Okay);
}
