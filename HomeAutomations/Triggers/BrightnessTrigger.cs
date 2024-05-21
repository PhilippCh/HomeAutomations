using System.Collections.Generic;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Triggers;

public class BrightnessTrigger : ITrigger
{
	public string? Id { get; init; }
	public SensorEntity Entity { get; init; }
	public int Min { get; init; }
	public int Max { get; init; } = int.MaxValue;

	public IObservable<bool> AsObservable() =>
		Entity
			.StateChanges()
			.Select(x => x.New?.State.AsInt())
			.StartWith(Entity.State.AsInt())
			.Select(x => x >= Min && x < Max)
			.DistinctUntilChanged();

	public IEnumerable<ITrigger> GetTriggersInternal() => [];
}
