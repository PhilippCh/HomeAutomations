using System;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using Notification = HomeAssistant.Automations.Models.Notification;

namespace HomeAutomations.Apps.KitchenLight;

public class KitchenLight : BaseAutomation<KitchenLight, KitchenLightConfig>
{
	public const int DefaultBrightnessPct = 100;

	private bool ShouldLightTurnOn => _lightEntity.IsOn() || _currentIlluminanceLux < Config.MinIlluminanceLux;

	private bool _isPermanentlyOn;
	private int _currentIlluminanceLux;
	private int _brightnessPct = DefaultBrightnessPct;
	private IDisposable? _currentCycleObserver;

	private readonly MqttService _mqttService;
	private readonly NotificationService _notificationService;
	private readonly LightEntity _lightEntity;

	public KitchenLight(MqttService mqttService, BaseAutomationDependencyAggregate<KitchenLight, KitchenLightConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_notificationService = notificationService;
		_lightEntity = new LightEntity(Context, Config.LightEntityId);
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_mqttService.Connect(GetType().Name, new[] { Config.CombinedSensorTopic, Config.ManualTriggerSensorTopic });
		_mqttService.GetMessagesForTopic<string>(Config.ManualTriggerSensorTopic).Subscribe(OnManualTriggerMessageReceived);
		_mqttService.GetMessagesForTopic<MotionSensorDeviceMessage>(Config.CombinedSensorTopic).Subscribe(OnMotionSensorUpdate);

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
		_lightEntity.TurnOn(brightness: DefaultBrightnessPct);
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

		_lightEntity.TurnOn(brightness: _brightnessPct);
		_currentCycleObserver?.Dispose();
		_currentCycleObserver = Observable.Return(new Unit())
			.Delay(Config.CycleTime)
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
