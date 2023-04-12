using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Vacuum;

public class Vacuum : BaseAutomation<Vacuum, VacuumConfig>
{
	private CancellationTokenSource? _cleaningScheduleCancellationToken;

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

		return Task.CompletedTask;
	}

	private void StartReminderCron()
	{
		_cleaningScheduleCancellationToken = new CancellationTokenSource();
		CronjobExtensions.ScheduleJob(Config.ReminderCrontab, SendReminder, cancellationToken: _cleaningScheduleCancellationToken.Token);
	}

	private void Reset()
	{
		_cleaningScheduleCancellationToken?.Cancel();

		StartReminderCron();
	}

	private void SendReminder()
	{
		Logger.Debug("Sending vacuum reminder notification");

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
			_ => () => Logger.Warning("Fired unknown notification action {Action}", action)
		};

		callback();
	}

	private void OnVacuumStateUpdated(StateChange stateChange)
	{
		Func<Task> action = stateChange switch
		{
			{
				New: VacuumState.Cleaning
			} => () =>
			{
				Reset();

				return Task.CompletedTask;
			},
			{
				Old: VacuumState.Idle, New: VacuumState.Returning
			} => ReturnToBase,
			{
				New: VacuumState.Returning
			} => async () =>
			{
				await SenCleanedAreaNotification();
				SendToBin();
			},
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

		Logger.Debug("Go to point [{X}, {Y}]", point.X, point.Y);
		Config.Vacuum.SendCommand("app_goto_target", new[] { point.X, point.Y });
	}

	private Task ReturnToBase()
	{
		Config.Vacuum.ReturnToBase();

		return Task.CompletedTask;
	}
}
