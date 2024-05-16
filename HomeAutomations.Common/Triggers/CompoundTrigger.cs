using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Extensions;

namespace HomeAutomations.Common.Triggers;

public class CompoundTrigger
{
	public IObservable<bool> Start { get; init; } = null!;
	public IObservable<bool> End { get; init; } = null!;

	public IObservable<bool> AsObservable() => Start
		.SwitchMap(x => x ? End.Select(y => !y).StartWith(true) : false.AsObservable())
		.DistinctUntilChanged();
}
