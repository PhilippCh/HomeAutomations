using System;
using System.Reactive;
using System.Reactive.Linq;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;
using NetDaemon.HassModel.Entities;
using Notification = HomeAssistant.Automations.Models.Notification;

namespace HomeAssistant.Automations.Apps.KitchenLight;

[NetDaemonApp]
public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	private bool ShouldLightTurnOn => _lightEntity.IsOn() || _currentIlluminanceLux < Config.MinIlluminanceLux;

	private bool _isPermanentlyOn;
	private int _currentIlluminanceLux;
	private IDisposable? _currentCycleObserver;

	private readonly MqttService _mqttService;
	private readonly NotificationService _notificationService;
	private readonly LightEntity _lightEntity;
	private readonly BinarySensorEntity _motionSensorEntity;

	public KitchenLight(MqttService mqttService, BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		var entities = new Entities(Context);

		_mqttService = mqttService;
		_notificationService = notificationService;
		_lightEntity = entities.Light.Bfb81fd992b98475f8tc6r;
		_motionSensorEntity = entities.BinarySensor.Motionsensorbedroom;
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.Configure<KitchenLightConfig>(config.GetSection("HomeAutomations:KitchenLight"));

	protected override void Start()
	{
		_mqttService.Connect(GetType().Name, new[] { Config.CombinedSensorTopic, Config.ManualTriggerSensorTopic });
		_mqttService.GetMessagesForTopic<string>(Config.ManualTriggerSensorTopic).Subscribe(OnManualTriggerMessageReceived);
		_mqttService.GetMessagesForTopic<MotionSensorDeviceMessage>(Config.CombinedSensorTopic)
			.DistinctUntilChanged()
			.Subscribe(OnMotionSensorUpdate);
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
		_lightEntity.TurnOn();
	}

	private void ToggleWithCycle()
	{
		if (_lightEntity.IsOff())
		{
			StartLightCycle();
		}
		else
		{
			StopLightCycle();
			_isPermanentlyOn = false;
			_lightEntity.TurnOff();
		}
	}

	private void StartLightCycle()
	{
		Logger.Information(_currentCycleObserver == null ? "Starting new light cycle." : "Restarting running light cycle.");

		_lightEntity.TurnOn();
		_currentCycleObserver?.Dispose();
		_currentCycleObserver = Observable.Return(new Unit())
			.Delay(TimeSpan.FromMinutes(Config.CycleTimeMinutes))
			.Do(
				_ =>
				{
					Logger.Information("Light cycle ended.");
					_lightEntity.TurnOff();
				})
			.Subscribe();
	}

	private void StopLightCycle() => _currentCycleObserver?.Dispose();
}
