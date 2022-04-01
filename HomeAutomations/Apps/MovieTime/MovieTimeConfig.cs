using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MovieTime;

public record MovieTimeConfig : Config
{
	public string StatusTopic { get; init; }
	public IEnumerable<string> SupportedActivities { get; init; }
	public IEnumerable<LightEntity> Lights { get; init; }
}
