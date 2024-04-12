using System.Globalization;
using System.Reactive.Concurrency;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.LaundryDay;

public class LaundryDay(
	BaseAutomationDependencyAggregate<LaundryDay, LaundryDayConfig> aggregate,
	IMqttEntityManager entityManager,
	BoschShcServices boschShcServices,
	NotificationService notificationService,
	IScheduler scheduler)
	: BaseAutomation<LaundryDay, LaundryDayConfig>(aggregate)
{
	private IDisposable? _scheduleObserver;
	private IDisposable? _ventilationReminderDelayedObserver;
	private IDisposable? _closeWindowTimerObserver;
	private bool _isVentilationRequested;
	private float _currentHumidity;

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await CreateEntityIfNotExistsAsync();
		await StartExistingDryingTimerAsync();

		Config.ButtonEntity.StateChanges()
			.Subscribe(x => OnButtonPressedAsync(x.New?.State));
		Config.Ventilation.HumiditySensor.StateChanges()
			.Where(_ => DateTime.Now.TimeOfDay >= Config.Ventilation.StartTime && DateTime.Now.TimeOfDay < Config.Ventilation.EndTime)
			.Subscribe(x => OnHumidityChanged(x.New?.State.AsFloat()));
		Config.Ventilation.WindowSensor.StateChanges()
			.Where(x => x.New?.IsOn() ?? false)
			.Subscribe(_ => OnOpenWindow());
	}

	private async Task CreateEntityIfNotExistsAsync()
	{
		if (Config.ResetDateSensorEntity.State == null)
		{
			await entityManager.CreateAsync(Config.ResetDateSensorEntity.EntityId, new EntityCreationOptions(UniqueId: Config.ResetDateSensorEntity.EntityId));
			await entityManager.SetStateAsync(Config.ResetDateSensorEntity.EntityId, string.Empty);
		}
	}

	private async Task StartExistingDryingTimerAsync()
	{
		if (DateTime.TryParse(Config.ResetDateSensorEntity.State, out var endDate))
		{
			await StartScenarioWithResetAsync(Config.Scenarios.Drying, endDate);
		}
	}

	private async Task OnButtonPressedAsync(string? state)
	{
		var action = WirelessSwitchActions.Map(state);

		if (action == ButtonAction.BrightnessUp)
		{
			Logger.Information("Resetting scenario to {Scenario}", Config.Scenarios.Default);
			await StartScenarioWithResetAsync(Config.Scenarios.Default, null);

			return;
		}

		if (WirelessSwitchActions.IsPressedAction(state))
		{
			await StartScenarioWithResetAsync(Config.Scenarios.Drying, DateTime.Now.AddDays(1));
		}
	}

	private async Task StartScenarioWithResetAsync(string scenario, DateTime? resetDate)
	{
		Logger.Information("Starting scenario {Scenario} until {ResetDate}", scenario, resetDate);

		boschShcServices.TriggerScenario(scenario);
		await entityManager.SetStateAsync(Config.ResetDateSensorEntity.EntityId, resetDate?.ToString(CultureInfo.InvariantCulture) ?? string.Empty);

		_scheduleObserver?.Dispose();

		if (resetDate != null)
		{
			_scheduleObserver = scheduler.ScheduleAsync(resetDate.Value, async (_, _) => await StartScenarioWithResetAsync(Config.Scenarios.Default, null));
		}
	}

	private void OnHumidityChanged(float? humidity)
	{
		if (humidity == null)
		{
			return;
		}

		_currentHumidity = humidity.Value;

		if (humidity < Config.Ventilation.MaxHumidity || Config.Ventilation.WindowSensor.IsOn())
		{
			ResetVentilationReminder();

			return;
		}

		_ventilationReminderDelayedObserver ??= Observable.Timer(Config.Ventilation.ReminderDelay)
			.Subscribe(
				_ =>
				{
					_ventilationReminderDelayedObserver?.Dispose();
					_isVentilationRequested = true;
					SendVentilationReminder(humidity.Value);
				});
	}

	private void SendVentilationReminder(float humidity)
	{
		Logger.Information("Sending ventilation reminder");
		notificationService.SendNotification(Config.Ventilation.Notification, humidity);
	}

	private void OnOpenWindow()
	{
		if (_isVentilationRequested)
		{
			StartCloseWindowTimer();

			return;
		}

		ResetVentilationReminder();
	}

	private void StartCloseWindowTimer()
	{
		Logger.Information("Starting timer for closing bedroom window after ventilation request");
		_closeWindowTimerObserver?.Dispose();
		_closeWindowTimerObserver = Observable.Interval(Config.Ventilation.CloseWindowTimeout)
			.Subscribe(
				_ =>
				{
					if (_currentHumidity < Config.Ventilation.MaxHumidity)
					{
						_closeWindowTimerObserver?.Dispose();
						notificationService.SendNotification(Config.Ventilation.CloseWindowNotification);
					}
				});
	}

	private void ResetVentilationReminder()
	{
		Logger.Information("Resetting ventilation reminder");
		_ventilationReminderDelayedObserver?.Dispose();
		_isVentilationRequested = false;
	}
}
