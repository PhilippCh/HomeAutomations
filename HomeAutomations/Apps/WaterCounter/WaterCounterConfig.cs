using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.WaterCounter;

public record WaterCounterConfig : Config
{
	public string EntityPrefix { get; init; }
	public string ResetCrontab { get; init; }
}
