using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Entities.Triggers;

public record BrightnessTriggerConfig
{
	public SensorEntity Entity { get; init; }
	public int MinBrightness { get; init; }
	public int MaxBrightness { get; init; } = int.MaxValue;
}

public class BrightnessTrigger : ICompoundTrigger
{
	private readonly BrightnessTriggerConfig _config;

	public BrightnessTrigger(BrightnessTriggerConfig config)
	{
		_config = config;
	}

	public IObservable<bool?> GetTrigger()
	{
		return _config.Entity.StateChanges()
			.Select(x => x.New?.State.AsInt())
			.StartWith(_config.Entity.State.AsInt())
			.Select(x => (x >= _config.MinBrightness && x < _config.MaxBrightness) as bool?);
	}
}
