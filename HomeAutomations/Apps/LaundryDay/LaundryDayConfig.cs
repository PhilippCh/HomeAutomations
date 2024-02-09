using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LaundryDay;

public record VentilationReminderConfig
{
	public TimeSpan StartTime { get; init; }
	public TimeSpan EndTime { get; init; }
	public BinarySensorEntity WindowSensor { get; init; }
	public SensorEntity HumiditySensor { get; init; }
	public int MaxHumidity { get; init; }
	public Notification Notification { get; init; }
	public Notification CloseWindowNotification { get; init; }
	public TimeSpan ReminderDelay { get; init; }
	public TimeSpan CloseWindowTimeout { get; init; }
}

public record ScenariosConfig
{
	public string Drying { get; init; }
	public string Default { get; init; }
}

public record LaundryDayConfig : Config
{
	public SensorEntity ButtonEntity { get; init; }
	public SensorEntity ResetDateSensorEntity { get; init; }
	public ScenariosConfig Scenarios { get; init; }

	public VentilationReminderConfig Ventilation { get; init; }
}
