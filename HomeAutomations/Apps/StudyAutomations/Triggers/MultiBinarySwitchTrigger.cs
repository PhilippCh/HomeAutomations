using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations.Triggers;

public class MultiBinarySwitchTrigger : ICompoundTrigger
{
	private readonly IEnumerable<BinarySensorEntity> _binarySensors;
	private readonly Func<IList<bool?>, bool>? _predicate;

	public MultiBinarySwitchTrigger(IEnumerable<BinarySensorEntity> binarySensors, Func<IList<bool?>, bool>? predicate = default)
	{
		_binarySensors = binarySensors;
		_predicate = predicate ?? (states => states.Any(s => s ?? false));
	}

	public IObservable<bool> GetTrigger()
	{
		return _binarySensors.Select(
				e => e.StateChanges()
					.Select(s => s.New.AsBoolean())
					.StartWith(e.EntityState.AsBoolean())
			)
			.CombineLatest()
			.Select(r => r.Any(s => s ?? false));
	}
}
