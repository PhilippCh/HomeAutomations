using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Shutters;

public record ShutterConfig
{
	public CoverEntity Entity { get; init; }
	public BinarySensorEntity ForceOpenOverride { get; init; }
}

public record ShuttersConfig : Config
{
	public double Latitude { get; init; }
	public double Longitude { get; init; }
	public TimeSpan CloseDelay { get; init; }
	public IEnumerable<ShutterConfig> Shutters { get; init; }
	public SensorEntity OpenSensorEntity { get; init; }
}
