using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public record CycleConfig
{
	public string Name { get; init; }
	public TimeConfig Start { get; init; }
	public TimeConfig End { get; init; }
	public TimeSpan? Interval { get; init; }
	public IReadOnlyList<IEnumerable<Entity>> EntityCycles { get; init; }
}

public record ScheduledLightsConfig : Config
{
	public double Latitude { get; init; }
	public double Longitude { get; init; }
	public TimeSpan UpdateInterval { get; init; }
	public IEnumerable<CycleConfig> LightCycles { get; init; }
}
