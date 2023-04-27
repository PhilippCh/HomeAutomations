using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.Reminders;

public record ReminderConfig
{
	public string Crontab { get; init; }
	public Notification Notification { get; init; }
}

public record RemindersConfig : Config
{
	public IEnumerable<ReminderConfig> Reminders { get; init; }
}
