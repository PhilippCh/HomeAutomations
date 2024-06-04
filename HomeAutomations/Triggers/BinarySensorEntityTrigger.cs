using System.Collections.Generic;
using System.Diagnostics;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Triggers;

public class BinarySensorEntityTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public BinarySensorEntity Entity { get; init; }

	public IObservable<bool> AsObservable() =>
		Entity
			.StateChanges()
			.Select(x => x.New)
			.StartWith(Entity.EntityState)
			.Select(x => x?.IsOn() ?? false)
			.Do(x => LatestValue = x)
			.DistinctUntilChanged();

	public IEnumerable<ITrigger> GetTriggersInternal() => [];
}
