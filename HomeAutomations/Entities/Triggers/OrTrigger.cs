using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Models;

namespace HomeAutomations.Entities.Triggers;

public class OrTrigger : ICompoundTrigger
{
	private readonly IEnumerable<IObservable<bool?>> _values;

	public OrTrigger(params IObservable<bool?>[] values)
	{
		_values = values;
	}

	public IObservable<bool?> GetTrigger() => _values.CombineLatest().Select(x => x.Any(y => y is true) as bool?);
}
