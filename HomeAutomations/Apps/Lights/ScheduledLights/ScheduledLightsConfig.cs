﻿using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public record CycleConfig
{
	public string Name { get; init; }
	public string StartTriggerId { get; init; }
	public string EndTriggerId { get; init; }
	public TimeSpan? Interval { get; init; }
	public BinarySensorEntity StateEntity { get; init; }
	public IReadOnlyList<IEnumerable<Entity>> EntityCycles { get; init; }
}

public record ScheduledLightsConfig : Config
{
	public IEnumerable<CycleConfig> LightCycles { get; init; }
}
