using HomeAutomations.Apps.UpdateInstagramToken;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.LightsSchedule;

public record LightsScheduleConfig : Config
{
	public string Latitude { get; init; }
	public string Longitude { get; init; }
}
