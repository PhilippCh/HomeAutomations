using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Vacuum;

[Focus]
public class Vacuum : BaseAutomation<Vacuum, VacuumConfig>
{
	private CancellationTokenSource? _cleaningScheduleCancellationToken;
	private IDisposable? _reminderLoopObserver;

	private readonly NotificationService _notificationService;

	public Vacuum(BaseAutomationDependencyAggregate<Vacuum, VacuumConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileNotificationActions(VacuumNotificationActions.Actions)
			.Subscribe(OnNotificationActionFired);
		Config.Vacuum.StateChanges().Subscribe(s => OnVacuumStateUpdated(new StateChange { Old = s.Old?.State, New = s.New?.State }));

		StartReminderCron();
		StartResetCron();

		return Task.CompletedTask;
	}

	private async void StartReminderCron()
	{
		_cleaningScheduleCancellationToken = new CancellationTokenSource();
		await CronjobExtensions.ScheduleJob(
			Config.ReminderCrontab, StartReminderLoop,
			cancellationToken: _cleaningScheduleCancellationToken.Token);
	}

	private async void StartResetCron()
	{
		await CronjobExtensions.ScheduleJob(Config.ResetCrontab, Reset, cancellationToken: CancellationToken.None);
	}

	private void Reset()
	{
		_cleaningScheduleCancellationToken?.Cancel();
		_reminderLoopObserver?.Dispose();

		StartReminderCron();
	}

	private void StartReminderLoop()
	{
		_reminderLoopObserver?.Dispose();
		_reminderLoopObserver = ObservableExtensions
			.Interval(Config.ReminderActiveInterval, true)
			.Subscribe(_ => SendReminder());
	}

	private void SendReminder()
	{
		Logger.Debug("Sending vacuum reminder notification.");

		if (!Config.Debug)
		{
			_notificationService.SendNotification(Config.Notifications.Reminder);
		}
	}

	private void OnNotificationActionFired(string action)
	{
		Action callback = action switch
		{
			VacuumNotificationActions.Start => () => Config.Vacuum.Start(),
			VacuumNotificationActions.NoStart => Reset,
			_ => () => Logger.Warning("Fired unknown notification action {action}.", action)
		};

		callback();
	}

	private void OnVacuumStateUpdated(StateChange stateChange)
	{
		Func<Task> action = stateChange switch
		{
			{
				New: VacuumState.Cleaning
			} => () => {
				Reset();
				return Task.CompletedTask;
			},
			{
				Old: VacuumState.Cleaning, New: VacuumState.Returning
			} => async () => {
				await SenCleanedAreaNotification();
				SendToBin();
			},
			{
				Old: VacuumState.Idle, New: VacuumState.Returning
			} => ReturnToBase,
			_ => () => Task.CompletedTask
		};

		action();
	}

	private async Task SenCleanedAreaNotification()
	{
		Config.Map.Entity.Snapshot($"/config/www/{Config.Map.ImageName}");
		_notificationService.SendNotification(Config.Notifications.CleanedArea);

		await Task.Delay(TimeSpan.FromSeconds(5));
	}

	private void SendToBin()
	{
		var point = new Vector2(33286, 32710); // Next to kitchen bin.

		Logger.Debug("Go to point [{x}, {y}]", point.X, point.Y);
		Config.Vacuum.SendCommand("app_goto_target", new[] { point.X, point.Y });
	}

	private Task ReturnToBase()
	{
		Config.Vacuum.ReturnToBase();

		return Task.CompletedTask;
	}
}
