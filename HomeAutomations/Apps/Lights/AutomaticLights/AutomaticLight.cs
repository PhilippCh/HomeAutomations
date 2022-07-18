using System.Linq;
using System.Reactive;
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

	private int _brightnessPct = DefaultBrightnessPct;
	private IDisposable? _lightCycleObserver;

	public AutomaticLight(AutomaticLightEntity entity, ILogger logger, NotificationService notificationService)
	{
		_entity = entity;
		_logger = logger;
		_notificationService = notificationService;
		entity.ManualTriggerSensor.StateChanges().Subscribe(s => OnManualTriggerStateChanged(s.New?.State));
		entity.MotionSensor.StateChanges().Subscribe(s => OnMotionSensorStateChanged(s.New?.Attributes));
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

		if (!_entity.Entity.IsOn() || LastIlluminance > _entity.MinIlluminance)
		{
			_logger.Information("{Illuminance} lux is too bright for {Entity}", LastIlluminance, _entity.Entity.EntityId);

			return;
		}

		_logger.Information("Motion detected");

		SetBrightness();
		StartLightCycle();
	}

	private void SetBrightness()
	{
		var timeOfDay = DateTime.Now.TimeOfDay;
		var activeBrightnessConfig = _entity.Brightness.FirstOrDefault(b => b.Start <= timeOfDay && timeOfDay <= b.End);

		if (activeBrightnessConfig != null)
		{
			_logger.Information(
				"Switching to brightness setting from {From} to {To}: {Value}% brightness",
				activeBrightnessConfig.Start, activeBrightnessConfig.End, activeBrightnessConfig.Percentage);
		}

		_brightnessPct = activeBrightnessConfig?.Percentage ?? DefaultBrightnessPct;
	}

	private void Reset()
	{
		StopLightCycle();
		IsPermanentlyOn = false;
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

		// Always turn on permanent lights with default brightness because it is a manual decision.
		_entity.Entity.TurnOn(brightness: DefaultBrightnessPct);
	}

	private void ToggleWithCycle()
	{
		if (_entity.Entity.IsOff())
		{
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
		_logger.Information(_lightCycleObserver == null ? "Starting new light cycle" : "Restarting running light cycle");

		_entity.Entity.TurnOn(brightness: _brightnessPct);
		_lightCycleObserver?.Dispose();
		_lightCycleObserver = Observable.Return(new Unit())
			.Delay(_entity.CycleTime)
			.Do(
				_ =>
				{
					_logger.Information("Light cycle ended");
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
