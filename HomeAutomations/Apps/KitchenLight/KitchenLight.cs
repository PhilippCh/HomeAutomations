using System.Linq;
using System.Reactive;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using Notification = HomeAutomations.Models.Notification;

namespace HomeAutomations.Apps.KitchenLight;

public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	private const int DefaultBrightnessPct = 100;

	private bool ShouldLightTurnOn => Config.LightEntity.IsOn() || _currentIlluminance < Config.MinIlluminance;

	private bool _isPermanentlyOn;
	private int _currentIlluminance;
	private int _brightnessPct = DefaultBrightnessPct;
	private IDisposable? _currentCycleObserver;

	private readonly NotificationService _notificationService;

	public KitchenLight(BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Config.ManualTriggerSensor.StateChanges().Subscribe(s => OnManualTriggerStateChanged(s.New?.State));
		Config.MotionSensor.StateChanges().Subscribe(s => OnMotionSensorUpdate(s.New?.Attributes));

		SetBrightness();

		return Task.CompletedTask;
	}

	private void OnMotionSensorUpdate(BinarySensorAttributes? attributes)
	{
		if (attributes == null)
		{
			return;
		}

		UpdateIlluminance((int?) attributes.IlluminanceLux);

		if (attributes.Occupancy != null && attributes.Occupancy.Value)
		{
			UpdateOccupancy();
		}
	}

	private void UpdateIlluminance(int? illuminance)
	{
		if (illuminance == null || illuminance == _currentIlluminance)
		{
			return;
		}

		_currentIlluminance = illuminance.Value;
		Logger.Information("Set illuminance to {Illuminance} lux", _currentIlluminance);
	}

	private void UpdateOccupancy()
	{
		if (_isPermanentlyOn)
		{
			return;
		}

		if (!ShouldLightTurnOn)
		{
			Logger.Information("{Illuminance} lux is too bright", _currentIlluminance);

			return;
		}

		Logger.Information("Motion detected");

		SetBrightness();
		StartLightCycle();
	}

	private void OnManualTriggerStateChanged(string? state)
	{
		var buttonAction = WirelessSwitchActions.Map(state);

		Action action = buttonAction switch
		{
			ButtonAction.Single => ToggleWithCycle,
			ButtonAction.Triple => Reset,
			ButtonAction.Hold => TurnOnPermanent,
			_ => () => {}
		};

		action();
	}

	private void SetBrightness()
	{
		var timeOfDay = DateTime.Now.TimeOfDay;
		var activeBrightnessConfig = Config.Brightness.FirstOrDefault(b => b.Start <= timeOfDay && timeOfDay <= b.End);

		if (activeBrightnessConfig != null)
		{
			Logger.Information(
				"Switching to brightness setting from {From} to {To}: {Value}% brightness",
				activeBrightnessConfig.Start, activeBrightnessConfig.End, activeBrightnessConfig.Percentage);
		}

		_brightnessPct = activeBrightnessConfig?.Percentage ?? DefaultBrightnessPct;
	}

	private void Reset()
	{
		StopLightCycle();
		_isPermanentlyOn = false;
		StartLightCycle();

		_notificationService.SendNotification(
			new Notification
			{
				Title = "Küchenlicht",
				Template = "Timer wurde zurückgesetzt."
			});
	}

	private void TurnOnPermanent()
	{
		StopLightCycle();
		_isPermanentlyOn = true;

		// Always turn on permanent lights with default brightness because it is a manual decision.
		Config.LightEntity.TurnOn(brightness: DefaultBrightnessPct);
	}

	private void ToggleWithCycle()
	{
		if (Config.LightEntity.IsOff())
		{
			StartLightCycle();
		}
		else
		{
			StopLightCycle();
			_isPermanentlyOn = false;
			Config.LightEntity.TurnOff();
		}
	}

	private void StartLightCycle()
	{
		// ReSharper disable once TemplateIsNotCompileTimeConstantProblem
		Logger.Information(_currentCycleObserver == null ? "Starting new light cycle" : "Restarting running light cycle");

		Config.LightEntity.TurnOn(brightness: _brightnessPct);
		_currentCycleObserver?.Dispose();
		_currentCycleObserver = Observable.Return(new Unit())
			.Delay(Config.CycleTime)
			.Do(
				_ =>
				{
					Logger.Information("Light cycle ended");
					StopLightCycle();
					Config.LightEntity.TurnOff();
				})
			.Subscribe();
	}

	private void StopLightCycle()
	{
		_currentCycleObserver?.Dispose();
		_currentCycleObserver = null;
	}
}
