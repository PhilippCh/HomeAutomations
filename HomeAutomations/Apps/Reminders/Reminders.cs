using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Reminders;

public class Reminders(BaseAutomationDependencyAggregate<Reminders, RemindersConfig> aggregate, INotificationService notificationService)
	: BaseAutomation<Reminders, RemindersConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		StartReminderCrons();

		return Task.CompletedTask;
	}

	private void StartReminderCrons()
	{
		foreach (var reminder in Config.Reminders)
		{
			CronjobExtensions.ScheduleJob(reminder.Crontab, () => notificationService.SendNotification(reminder.Notification));
		}
	}
}
