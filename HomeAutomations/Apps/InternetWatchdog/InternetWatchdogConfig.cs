using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.InternetWatchdog;

public record InternetWatchdogConfig : Config
{
	public SensorEntity SensorEntity { get; init; }

	public Notification InternetDownNotification { get; init; }
	public Notification InternetUpNotification { get; init; }
}
