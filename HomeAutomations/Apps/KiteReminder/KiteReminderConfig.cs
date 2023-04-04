using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.KiteReminder;

public record WindThresholds
{
	public double Speed { get; init; }
	public double GustSpeed { get; init; }
}

public record OpenWeatherMapConfig
{
	public string BaseUrl { get; init; }
	public string ApiKey { get; init; }
}

public record KiteReminderConfig : Config
{
	public string CheckCrontab { get; init; }
	public string ResetCrontab { get; init; }
	public OpenWeatherMapConfig OpenWeatherMap { get; init; }
	public double Latitude { get; init; }
	public double Longitude { get; init; }
	public WindThresholds Thresholds { get; init; }
	public Notification Notification { get; init; }
	public TimeSpan EnableNotificationTime { get; init; }
	public TimeSpan DisableNotificationTime { get; init; }
}
