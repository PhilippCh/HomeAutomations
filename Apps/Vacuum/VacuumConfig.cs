using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Vacuum;

public record VacuumConfig : Config
{
	public VacuumEntity Vacuum { get; init; }
	public string ReminderCrontab { get; init; }
	public string ResetCrontab { get; init; }
	public TimeSpan ReminderActiveInterval { get; init; }
	public Notification Reminder { get; init; }
}
