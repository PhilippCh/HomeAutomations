using HomeAutomations.Common.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations.Triggers;

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

	public IObservable<bool> GetTrigger()
	{
		return _config.Entity.StateChanges()
			.Select(x => x.New?.State)
			.TryParseInt()
			.Select(x => x >= _config.MinBrightness && x < _config.MaxBrightness);
	}
}
