using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Models;

namespace HomeAutomations.Entities.Triggers;

public class AndTrigger : ICompoundTrigger
{
	private readonly IEnumerable<IObservable<bool?>> _values;

	public AndTrigger(params IObservable<bool?>[] values)
	{
		_values = values;
	}

	public IObservable<bool?> GetTrigger() => _values.CombineLatest().Select(x => x.All(y => y is true) as bool?);
}
