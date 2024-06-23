using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.InternetWatchdog;

public record HostCheckConfig {
	public string Host { get; init; }
	public TimeSpan Interval { get; init; }
	public BinarySensorEntity ResultEntity { get; init; }
}

public record InternetWatchdogConfig : Config
{
	public HostCheckConfig Check { get; init; }

	public Notification InternetDownNotification { get; init; }
	public Notification InternetUpNotification { get; init; }
}
