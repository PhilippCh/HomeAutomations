using System;
using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.Vacuum
{
	[UsedImplicitly]
	public record VacuumNotificationConfig
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
