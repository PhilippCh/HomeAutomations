using HomeAssistant.Automations.Models;
using HomeAutomations.Models;
using JetBrains.Annotations;

namespace HomeAutomations.Apps.Vacuum
{
	[UsedImplicitly]
	public class VacuumNotificationConfig
	{
		public Notification Reminder { get; init; }
		public Notification CleanBedroom { get; init; }
		public Notification EmptyBin { get; init; }
	}

	public record VacuumConfig : Config
	{
		public string Entity { get; init; }
		public string CleaningSchedule { get; init; }
		public TimeSpan ReminderInterval { get; init; }
		public VacuumNotificationConfig Notifications { get; init; }
	}
}
