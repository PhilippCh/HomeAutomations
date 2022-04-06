using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.RazorBladeUsage;

public record RazorBladeUsageConfig : Config
{
	public SensorEntity Sensor { get; init; }
	public string CounterTopic { get; init; }
}
