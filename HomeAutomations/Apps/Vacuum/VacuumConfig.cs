using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Vacuum;

public record VacuumMapConfig
{
	public CameraEntity Entity { get; init; }
	public string ImageName { get; init; }
}

public record VacuumNotificationConfig
{

	public Notification Reminder { get; init; }
	public Notification CleanedArea { get; init; }
}

public record VacuumConfig : Config
{
	public VacuumEntity Vacuum { get; init; }
	public VacuumMapConfig Map { get; init; }
	public string ReminderCrontab { get; init; }
	public VacuumNotificationConfig Notifications { get; init; }
}
