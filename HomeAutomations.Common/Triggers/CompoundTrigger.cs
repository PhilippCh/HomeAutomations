using System.Reactive.Linq;
using HomeAutomations.Common.Extensions;

namespace HomeAutomations.Common.Triggers;

public class CompoundTrigger : ITrigger
{
	public ITrigger Start { get; init; } = null!;
	public ITrigger End { get; init; } = null!;

	public IObservable<bool> AsObservable()
	{
		var endTrigger = End.AsObservable().Select(y => !y).StartWith(true);

		return Start
			.AsObservable()
			.SwitchMap(x => x ? endTrigger : false.AsObservable())
			.DistinctUntilChanged();
	}
}
