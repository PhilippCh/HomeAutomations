using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Extensions;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using Microsoft.Extensions.Options;
using NetDaemon.Common;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Common;

namespace HomeAssistant.Automations.Apps.Vacuum
{
    [NetDaemonApp]
    public class VacuumReminder
    {
        private const string ResetCrontab = "0 0 * * *";

        private CancellationTokenSource? _cleaningScheduleCancellationToken;
        private IDisposable? _reminderLoopObserver;

        private readonly IOptionsMonitor<VacuumConfig> _config;
        private readonly HomeAssistantGenerated.Services _services;
        private readonly NotificationService _notificationService;

        public VacuumReminder(IHaContext context, INetDaemonScheduler scheduler, IOptionsMonitor<VacuumConfig> config)
        {
            _config = config;
            _config.OnChange(_ => Reset());
            _notificationService = new NotificationService(new HomeAssistantGenerated.Services(context));

            StartCleaningSchedule(_config.CurrentValue.CleaningSchedule);
            StartResetSchedule();
        }

        private async void StartCleaningSchedule(string schedule)
        {
            _cleaningScheduleCancellationToken = new CancellationTokenSource();
            await CronjobExtensions.ScheduleJob(schedule, StartReminderLoop, _cleaningScheduleCancellationToken.Token);
        }

        private async void StartResetSchedule()
        {
            await CronjobExtensions.ScheduleJob(ResetCrontab, Reset, CancellationToken.None);
        }

        private void Reset()
        {
            _cleaningScheduleCancellationToken?.Cancel();
            _reminderLoopObserver?.Dispose();

            StartCleaningSchedule(_config.CurrentValue.CleaningSchedule);
        }

        private void StartReminderLoop()
        {
            _reminderLoopObserver?.Dispose();
            _reminderLoopObserver = Observable
                .Interval(TimeSpan.FromMinutes(_config.CurrentValue.ReminderEveryMinutes))
                .Subscribe(_ => SendReminder());
        }

        private void SendReminder()
        {
            _notificationService.SendNotification(_config.CurrentValue.Reminder);
        }
    }
}