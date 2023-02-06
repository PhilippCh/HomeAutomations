using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
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

	private int _brightness = DefaultBrightnessPct;
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
		disposables.Add(_entity.ManualTriggerSensor.StateChanges().Subscribe(s => OnManualTriggerStateChanged(s.New?.State)));
		disposables.Add(_entity.MotionSensor.Entity.StateChanges().Subscribe(s => OnMotionSensorStateChanged(s.New?.Attributes)));

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

	private void OnMotionSensorStateChanged(BinarySensorAttributes? attributes)
	{
		if (attributes == null)
		{
			return;
		}

		if (!_entity.MotionSensor.ActiveIntervals.Any(i => i.IsActiveFor(DateTime.Now.TimeOfDay)))
		{
			// We're not in any active motion sensor interval, so cancel.
			return;
		}

		LastIlluminance = attributes.IlluminanceLux ?? LastIlluminance;

		if (attributes.Occupancy != null && attributes.Occupancy.Value)
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

		if (!_entity.Entity.IsOn() && LastIlluminance > _entity.MaxIlluminance)
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
		var date = DateTime.Now.TimeOfDay;
		var activeBrightnessConfig = _entity.Brightness.FirstOrDefault(b => b.Interval.IsActiveFor(date));

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

		_entity.Entity.TurnOn(brightness: _brightness);
		_lightCycleObserver?.Dispose();
		_lightCycleObserver = Observable.Return(new Unit())
			.Delay(_entity.CycleTime)
			.Do(
				_ =>
				{
					_logger.Information("Light cycle ended for {Light}", _entity.Entity.GetName());
					StopLightCycle();
					_entity.Entity.TurnOff();
				})
			.Subscribe();
	}

	private void StopLightCycle()
	{
		_lightCycleObserver?.Dispose();
		_lightCycleObserver = null;
	}
}
