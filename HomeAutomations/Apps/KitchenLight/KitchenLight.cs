﻿using System.Linq;
using System.Reactive;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using Notification = HomeAutomations.Models.Notification;

namespace HomeAutomations.Apps.KitchenLight;

public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	public const int DefaultBrightnessPct = 100;

	private bool ShouldLightTurnOn => Config.LightEntity.IsOn() || _currentIlluminanceLux < Config.MinIlluminanceLux;

	private bool _isPermanentlyOn;
	private int _currentIlluminanceLux;
	private int _brightnessPct = DefaultBrightnessPct;
	private IDisposable? _currentCycleObserver;

	private readonly MqttService _mqttService;
	private readonly NotificationService _notificationService;

	public KitchenLight(MqttService mqttService, BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_notificationService = notificationService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		(await _mqttService.GetMessagesForTopic<string>(Config.ManualTriggerSensorTopic)).Subscribe(OnManualTriggerMessageReceived);
		(await _mqttService.GetMessagesForTopic<MotionSensorDeviceMessage>(Config.CombinedSensorTopic)).Subscribe(OnMotionSensorUpdate);

		SetBrightness();
	}

	private void OnMotionSensorUpdate(MotionSensorDeviceMessage? m)
	{
		UpdateIlluminance(m?.IlluminanceLux);

		if (m?.Occupancy != null && m.Occupancy)
		{
			UpdateOccupancy();
		}
	}

	private void UpdateIlluminance(int? illuminanceLux)
	{
		if (illuminanceLux != null && illuminanceLux != _currentIlluminanceLux)
		{
			_currentIlluminanceLux = illuminanceLux.Value;
			Logger.Information("Set illuminance to {illuminance} lux.", _currentIlluminanceLux);
		}
	}

	private void UpdateOccupancy()
	{
		if (_isPermanentlyOn)
		{
			return;
		}

		if (!ShouldLightTurnOn)
		{
			Logger.Information("{illuminance} lux is too bright.", _currentIlluminanceLux);

			return;
		}

		Logger.Information("Motion detected.");

		SetBrightness();
		StartLightCycle();
	}

	private void OnManualTriggerMessageReceived(string? message)
	{
		Action action = message switch
		{
			WirelessSwitchActions.Hold => TurnOnPermanent,
			WirelessSwitchActions.Triple => Reset,
			WirelessSwitchActions.Release => () => {},
			_ => ToggleWithCycle
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
				"Switching to brightness setting from {from} to {to}: {value}% brightness.",
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
		Logger.Information(_currentCycleObserver == null ? "Starting new light cycle." : "Restarting running light cycle.");

		Config.LightEntity.TurnOn(brightness: _brightnessPct);
		_currentCycleObserver?.Dispose();
		_currentCycleObserver = Observable.Return(new Unit())
			.Delay(Config.CycleTime)
			.Do(
				_ =>
				{
					Logger.Information("Light cycle ended.");
					Config.LightEntity.TurnOff();
				})
			.Subscribe();
	}

	private void StopLightCycle() => _currentCycleObserver?.Dispose();
}