using System.Reactive.Linq;

namespace HomeAutomations.Common.Triggers;

public class TriggerRefTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public string? RefId { get; init; }

	private ITrigger? _ref;

	public void ResolveRef(IEnumerable<ITrigger> topLevelTriggers)
	{
		var refTrigger = topLevelTriggers.FirstOrDefault(x => x.Id == RefId);
		_ref = refTrigger;
	}

	public IObservable<bool> AsObservable() =>
		_ref?
			.AsObservable()
			.Do(x => LatestValue = x) ??
		Observable.Throw<bool>(new InvalidOperationException($"Ref trigger {RefId} not resolved."));

	/// <summary>
	/// This method always returns an empty collection in TriggerRefTrigger, so that recursion used in resolving trigger references is stopped at this point.
	/// </summary>
	public IEnumerable<ITrigger> GetTriggersInternal() => new[] { _ref! };
}
