using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using Notification = HomeAutomations.Models.Notification;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

public class AutomaticLight
{
	private const int DefaultBrightnessPct = 100;

	private double LastIlluminance { get; set; }
	private bool IsPermanentlyOn { get; set; }

	private readonly AutomaticLightEntity _entity;
	private readonly ILogger _logger;
	private readonly NotificationService _notificationService;

	private int? _brightness = DefaultBrightnessPct;
	private IDisposable? _lightCycleObserver;

	public AutomaticLight(AutomaticLightEntity entity, ILogger logger, NotificationService notificationService)
	{
		_entity = entity;
		_logger = logger;
		_notificationService = notificationService;
	}

	public IDisposable StartMonitoring()
	{
		var disposables = new CompositeDisposable();
		var motionSensorStateChanges = _entity.MotionSensor.Entity.StateChangesWithCurrentState<BinarySensorEntity, BinarySensorAttributes>();
		var illuminanceSensorStateChanges = _entity.IlluminanceSensor.StateChangesWithCurrentState<SensorEntity, SensorAttributes>();
		var stateChanges = motionSensorStateChanges
			.CombineLatest(illuminanceSensorStateChanges)
			.Subscribe(
				x =>
				{
					var (motion, illuminance) = x;
					OnMotionSensorStateChanged(motion.New?.IsOn(), illuminance.New?.AsInt());
				});

		disposables.Add(stateChanges);

		if (_entity.ManualTriggerSensor is not null)
		{
			var manualTriggerStateChanges = _entity.ManualTriggerSensor.StateChanges()
				.Subscribe(s => OnManualTriggerStateChanged(s.New?.State));
			disposables.Add(manualTriggerStateChanges);
		}

		return disposables;
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

	private void OnMotionSensorStateChanged(bool? isOccupied, int? illuminance)
	{
		if (!_entity.MotionSensor.ActiveIntervals.Any(i => i.IsActiveFor(DateTime.Now.TimeOfDay)))
		{
			// We're not in any active motion sensor interval, so cancel.
			return;
		}

		LastIlluminance = illuminance ?? LastIlluminance;

		if (isOccupied != null && isOccupied.Value)
		{
			UpdateOccupancy();
		}
	}

	private void UpdateOccupancy()
	{
		if (IsPermanentlyOn)
		{
			return;
		}

		if (LastIlluminance > _entity.MaxIlluminance)
		{
			_logger.Information("{Illuminance} lux is too bright for {Light}", LastIlluminance, _entity.Entity.GetName());

			return;
		}

		_logger.Information("Motion detected");

		SetBrightness();
		StartLightCycle();
	}

	private void SetBrightness()
	{
		var activeBrightnessConfig = _entity.Brightness?.FirstOrDefault(b => b.Interval.IsActiveFor(DateTime.Now.TimeOfDay));

		if (activeBrightnessConfig != null)
		{
			_logger.Information(
				"Switching to brightness setting from {From} to {To}: {Value}% brightness for {Light}",
				activeBrightnessConfig.Interval.Start, activeBrightnessConfig.Interval.End, activeBrightnessConfig.Percentage, _entity.Entity.GetName());
		}

		_brightness = (activeBrightnessConfig?.Percentage ?? DefaultBrightnessPct) * _entity.MaxBrightness / 100;
	}

	private void Reset()
	{
		StopLightCycle();
		IsPermanentlyOn = false;
		SetBrightness();
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
		IsPermanentlyOn = true;

		_logger.Information("Turning {Light} on permanently", _entity.Entity.GetName());

		// Always turn on permanent lights with default brightness because it is a manual decision.
		_entity.Entity.TurnOn(brightness: DefaultBrightnessPct * _entity.MaxBrightness);
	}

	private void ToggleWithCycle()
	{
		if (_entity.Entity.IsOff())
		{
			SetBrightness();
			StartLightCycle();
		}
		else
		{
			StopLightCycle();
			IsPermanentlyOn = false;
			_entity.Entity.TurnOff();
		}
	}

	private void StartLightCycle()
	{
		// ReSharper disable once TemplateIsNotCompileTimeConstantProblem
		_logger.Information(_lightCycleObserver == null ? "Starting new light cycle for {Light}" : "Restarting running light cycle for {Light}", _entity.Entity.GetName());

		TurnLightOn();

		_lightCycleObserver?.Dispose();
		_lightCycleObserver = Observable.Return(new Unit())
			.Delay(_entity.CycleTime)
			.Do(_ => FinishOrRestartCycle())
			.Subscribe();
	}

	private void TurnLightOn()
	{
		if (_entity.MaxBrightness != null)
		{
			_entity.Entity.TurnOn(brightness: _brightness);
		}
		else
		{
			// For some reason the zigbee2mqtt configuration to assign brightness via the SET message doesn't seem to work for some light,
			// so as a workaround we can disable setting brightness when turning on the lights.
			_entity.Entity.TurnOn();
		}
	}

	private void FinishOrRestartCycle()
	{
		if (_entity.MotionSensor.Entity.IsOn())
		{
			// There's still someone present, restart the cycle.
			StartLightCycle();

			return;
		}

		// There's no one present anymore, so end the cycle.
		_logger.Information("Light cycle finished for {Light}", _entity.Entity.GetName());
		StopLightCycle();
		_entity.Entity.TurnOff();
	}

	private void StopLightCycle()
	{
		_lightCycleObserver?.Dispose();
		_lightCycleObserver = null;
	}
}
