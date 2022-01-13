using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using HomeAssistant.Automations.Extensions;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;
using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps.KitchenLight;

[NetDaemonApp]
public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	private bool ShouldLightTurnOn => _lightEntity.IsOn() || _currentIlluminanceLux < Config.MinIlluminanceLux;

	private bool _isPermanentlyOn;
	private int _currentIlluminanceLux;
	private IDisposable? _currentCycleObserver;

	private readonly MqttService _mqttService;
	private readonly LightEntity _lightEntity;
	private readonly BinarySensorEntity _motionSensorEntity;

	public KitchenLight(MqttService mqttService, BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate)
		: base(aggregate)
	{
		var entities = new Entities(Context);

		_mqttService = mqttService;
		_lightEntity = entities.Light.Bfb81fd992b98475f8tc6r;
		_motionSensorEntity = entities.BinarySensor.Motionsensorbedroom;
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.Configure<KitchenLightConfig>(config.GetSection("HomeAssistant.Automations:KitchenLight"));

	protected override void Start()
	{
		_mqttService.Connect(GetType().Name, new[] { Config.LightSensorTopic, Config.ManualTriggerSensorTopic });
		_mqttService.GetMessagesForTopic<LightSensorDeviceMessage>(Config.LightSensorTopic).Subscribe(SetIlluminanceLux);
		_mqttService.GetMessagesForTopic<string>(Config.ManualTriggerSensorTopic).Subscribe(OnManualTriggerMessageReceived);

		// TODO: Use MQTT listener when new PIR sensor is here.
		_motionSensorEntity.StateChanges()
			.Where(s => s.Old!.State != "on" && s.New!.State == "on")
			.Subscribe(_ => OnMotionDetected());
	}

	private void SetIlluminanceLux(LightSensorDeviceMessage? m)
	{
		_currentIlluminanceLux = m?.IlluminanceLux ?? _currentIlluminanceLux;
		Logger.Information("Set illuminance to {illuminance} lux.", _currentIlluminanceLux);
	}

	private void OnMotionDetected()
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
			WirelessSwitchActions.Release => () => {},
			_ => ToggleWithCycle
		};

		action();
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
