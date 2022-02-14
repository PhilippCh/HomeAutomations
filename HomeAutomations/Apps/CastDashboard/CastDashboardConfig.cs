using System.Collections.Generic;
using HomeAssistant.Automations.Models;

namespace HomeAssistant.Automations.Apps.Cast;

public record CastDashboardConfig : Config
{
	public long MinCastDistance { get; init; }
	public string Target { get; init; }
	public string DashboardPath { get; init; }
	public string ViewPath { get; init; }
	public IEnumerable<string> PresenceSensors { get; init; }
}
