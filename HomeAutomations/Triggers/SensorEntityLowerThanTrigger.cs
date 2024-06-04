using System.Collections.Generic;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Triggers;

public class SensorEntityLowerThanTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public SensorEntity Entity { get; init; }
	public float Threshold { get; init; }

	public IObservable<bool> AsObservable() =>
		Entity
			.StateChanges()
			.Select(x => x.New?.State.AsFloat())
			.StartWith(Entity.State.AsFloat())
			.WhereNotNull()
			.Select(x => x < Threshold)
			.Do(x => LatestValue = x);

	public IEnumerable<ITrigger> GetTriggersInternal() => [];
}
