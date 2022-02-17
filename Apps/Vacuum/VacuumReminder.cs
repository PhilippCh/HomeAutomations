using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Apps.Vacuum;
using HomeAssistant.Automations.Apps.Vacuum.StateMachine;
using HomeAssistant.Automations.Extensions;
using HomeAutomations.Apps.Vacuum.StateMachine;
using HomeAutomations.Models;
using HomeAutomations.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ObservableExtensions = HomeAssistant.Automations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Vacuum;

public class VacuumReminder : BaseAutomation<VacuumReminder, VacuumConfig>
{
	private const string ResetCrontab = "0 0 * * *";

	private CancellationTokenSource? _cleaningScheduleCancellationToken;
	private IDisposable? _reminderLoopObserver;
	private IDisposable? _reminderActionObserver;

	private readonly VacuumService _vacuumService;
	private readonly NotificationService _notificationService;

	public VacuumReminder(
		VacuumService vacuumService,
		NotificationService notificationService,
		BaseAutomationDependencyAggregate<VacuumReminder, VacuumConfig> aggregate)
		: base(aggregate)
	{
		_vacuumService = vacuumService;
		_notificationService = notificationService;
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddTransient<VacuumStateMachine>()
			.AddTransient<VacuumStateProvider>()
			.AddScoped<VacuumService>();

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		StartCleaningSchedule(Config.CleaningSchedule);
		StartResetSchedule();
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

		StartCleaningSchedule(Config.CleaningSchedule);
	}

	private void StartReminderLoop()
	{
		_reminderLoopObserver?.Dispose();
		_reminderLoopObserver = ObservableExtensions
			.Interval(Config.ReminderInterval, true)
			.Subscribe(_ => SendReminder());
		_reminderActionObserver = _notificationService.NotificationActionFired.Subscribe(OnNotificationActionFired);
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
			VacuumNotificationActions.Start => () => _vacuumService.Start(),
			VacuumNotificationActions.StartWithBedroom => () => _vacuumService.StartWithBedroom(),
			VacuumNotificationActions.NoStart => Reset,
			_ => () => {}
		};

		callback();
	}
}
