using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Triggers;

public class BooleanTrigger : ITrigger
{
	public string? Id { get; init; }
	public ITrigger Condition { get; init; } = null!;
	public ITrigger TrueTrigger { get; init; } = null!;
	public ITrigger FalseTrigger { get; init; } = null!;

	public IObservable<bool> AsObservable() =>
		Condition
			.AsObservable()
			.SwitchMap(x => x ? TrueTrigger.AsObservable() : FalseTrigger.AsObservable())
			.DistinctUntilChanged();
}
