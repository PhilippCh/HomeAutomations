using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Counters;

public record CounterButtonConfig
{
	public SensorEntity Sensor { get; init; }
	public string AssociatedUser { get; init; }
}

public record CounterEvents
{
	public string AddEventId { get; init; }
	public string SetTargetEventId { get; init; }
	public string UserProperty { get; init; }
	public string AmountProperty { get; init; }
}

public record CounterConfig : Config
{
	public string Name { get; init; }
	public string EntityPrefix { get; init; }
	public string EntityDescriptionPrefix { get; init; }
	public CounterButtonConfig? Button { get; init; }
	public string ResetCrontab { get; init; }
	public CounterEvents Events { get; init; }
}
