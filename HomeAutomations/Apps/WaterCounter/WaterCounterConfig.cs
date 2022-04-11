using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.WaterCounter;

public record WaterCounterConfig : Config
{
	public string ResetCrontab { get; init; }
}
