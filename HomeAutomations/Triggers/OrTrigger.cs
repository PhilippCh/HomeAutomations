using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Triggers;

public class OrTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public IEnumerable<ITrigger> Triggers { get; init; } = null!;

	public IObservable<bool> AsObservable() =>
		Triggers
			.Select(x => x.AsObservable())
			.CombineLatest()
			.Select(x => x.Any(y => y))
			.Do(x => LatestValue = x)
			.DistinctUntilChanged();

	public IEnumerable<ITrigger> GetTriggersInternal() => Triggers;
}
