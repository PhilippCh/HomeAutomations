using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading;
using HomeAssistant.Automations.Extensions;
using HomeAssistant.Automations.Services;
using Microsoft.Extensions.Options;
using NetDaemon.Common;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Common;
using Serilog;
using ObservableExtensions = HomeAssistant.Automations.Extensions.ObservableExtensions;

namespace HomeAssistant.Automations.Apps.Vacuum
{
	[NetDaemonApp]
	public class VacuumReminder
	{
		private const string ResetCrontab = "0 0 * * *";

		private CancellationTokenSource? _cleaningScheduleCancellationToken;
		private IDisposable? _reminderLoopObserver;
		private IDisposable? _reminderActionObserver;

		private readonly VacuumService _vacuumService;
		private readonly NotificationService _notificationService;
		private readonly IOptionsMonitor<VacuumConfig> _config;

		public VacuumReminder(
			VacuumService vacuumService,
			NotificationService notificationService,
			IOptionsMonitor<VacuumConfig> config)
		{
			_vacuumService = vacuumService;
			_notificationService = notificationService;
			_config = config;
			_config.OnChange(_ => Reset());

			StartCleaningSchedule(_config.CurrentValue.CleaningSchedule);
			StartResetSchedule();

			_vacuumService.Start();
		}

		private async void StartCleaningSchedule(string schedule)
		{
			_cleaningScheduleCancellationToken = new CancellationTokenSource();
			await CronjobExtensions.ScheduleJob(
				schedule, StartReminderLoop,
				cancellationToken: _cleaningScheduleCancellationToken.Token, runOnStartup: true);
		}

		private async void StartResetSchedule()
		{
			await CronjobExtensions.ScheduleJob(ResetCrontab, Reset, cancellationToken: CancellationToken.None);
		}

		private void Reset()
		{
			_cleaningScheduleCancellationToken?.Cancel();
			_reminderLoopObserver?.Dispose();
			_reminderActionObserver?.Dispose();

			StartCleaningSchedule(_config.CurrentValue.CleaningSchedule);
		}

		private void StartReminderLoop()
		{
			_reminderLoopObserver?.Dispose();
			_reminderLoopObserver = ObservableExtensions
				.Interval(TimeSpan.FromMinutes(_config.CurrentValue.ReminderIntervalMinutes), true)
				.Subscribe(_ => SendReminder());
			_reminderActionObserver = _notificationService.NotificationActionFired.Subscribe(OnNotificationActionFired);
		}

		private void SendReminder()
		{
			_notificationService.SendNotification(_config.CurrentValue.Reminder);
		}

		private void OnNotificationActionFired(string action)
		{
			Action callback = action switch
			{
				VacuumNotificationActions.Start => () => _vacuumService.Start(),
				VacuumNotificationActions.StartWithBedroom => () => _vacuumService.StartWithBedroom(),
				VacuumNotificationActions.NoStart => Reset,
				_ => () => {}
			};

			callback();
		}
	}
}
