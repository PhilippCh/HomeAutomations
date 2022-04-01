using HomeAssistant.Automations.Models;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.KratomCounter;

public record KratomCounterConfig : Config
{
	public string CounterTopic { get; init; }
	public InputNumberEntity Counter { get; init; }
	public string ResetCrontab { get; init; }
	public string EventName { get; init; }
	public Notification Notification { get; init; }
}
