using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Reminders;

public class Reminders : BaseAutomation<Reminders, RemindersConfig>
{
	private readonly NotificationService _notificationService;

	public Reminders(BaseAutomationDependencyAggregate<Reminders, RemindersConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		StartReminderCrons();

		return Task.CompletedTask;
	}

	private void StartReminderCrons()
	{
		foreach (var reminder in Config.Reminders)
		{
			CronjobExtensions.ScheduleJob(reminder.Crontab, () => _notificationService.SendNotification(reminder.Notification));
		}
	}
}
