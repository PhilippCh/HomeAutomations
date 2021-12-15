using System;
using System.Reactive;
using System.Reactive.Linq;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using NetDaemon.Common;
using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps.KitchenLight;

[NetDaemonApp]
public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	private int _lastReportedIlluminance;
	private IDisposable? _currentCycleObserver;

	private readonly PingService _pingService;
	private readonly MqttService _mqttService;
	private readonly LightEntity _lightEntity;

	public KitchenLight(PingService pingService, MqttService mqttService, BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate)
		: base(aggregate)
	{
		_pingService = pingService;
		_mqttService = mqttService;
		_lightEntity = new Entities(Context).Light.Bfb81fd992b98475f8tc6r;
	}

	protected override void Start()
	{
		_mqttService.Connect(GetType().Name, new[] { Config.LightSensorTopic, Config.ManualTriggerSensor });
		_mqttService.GetMessagesForTopic<LightSensorDeviceMessage>(Config.LightSensorTopic).Subscribe(m => _lastReportedIlluminance = m.IlluminanceLux);
		_mqttService.GetMessagesForTopic<WirelessSwitchDeviceMessage>(Config.ManualTriggerSensor).Subscribe(OnManualTriggerMessageReceived);

		var pingInterval = Config.MotionSensor.PingIntervalMs;

		Observable
			.Interval(TimeSpan.FromMilliseconds(pingInterval))
			.Select(_ => _pingService.Ping(Config.MotionSensor.Host, pingInterval * 0.8f))
			.Switch()
			.Where(result => result)
			.Throttle(TimeSpan.FromSeconds(Config.MotionSensor.ThrottleAfterWakeSeconds))
			.Subscribe(_ => OnMotionDetected());
	}

	private void OnMotionDetected()
	{
		Console.WriteLine("Motion detected.");
	}

	private void OnManualTriggerMessageReceived(WirelessSwitchDeviceMessage message)
	{
		_lightEntity.Toggle();

		if (_lightEntity.IsOn())
		{
			_currentCycleObserver?.Dispose();
			_currentCycleObserver = CreateManuallyTriggeredLightCycle().Subscribe();
		}
	}

	private IObservable<Unit> CreateManuallyTriggeredLightCycle() =>
		Observable.Return(new Unit())
			.Delay(TimeSpan.FromMinutes(Config.CycleTimeMinutes))
			.Do(_ => _lightEntity.TurnOff());
}
