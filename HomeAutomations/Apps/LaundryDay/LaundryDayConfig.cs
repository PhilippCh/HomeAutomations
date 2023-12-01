using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LaundryDay;

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
}
