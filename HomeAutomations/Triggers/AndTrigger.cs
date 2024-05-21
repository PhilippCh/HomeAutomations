using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Triggers;

public class AndTrigger : ITrigger
{
	public string? Id { get; init; }
	public IEnumerable<ITrigger> Triggers { get; init; } = null!;

	public IObservable<bool> AsObservable() =>
		Triggers
			.Select(x => x.AsObservable())
			.CombineLatest()
			.Select(x => x.All(y => y))
			.DistinctUntilChanged();
}
