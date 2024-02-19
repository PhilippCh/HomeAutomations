using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Entities.Triggers;

public class MultiBinarySwitchTrigger : ICompoundTrigger
{
	private readonly IEnumerable<BinarySensorEntity> _binarySensors;

	public MultiBinarySwitchTrigger(IEnumerable<BinarySensorEntity> binarySensors)
	{
		_binarySensors = binarySensors;
	}

	public IObservable<bool?> GetTrigger()
	{
		return _binarySensors.Select(
				e => e.StateChanges()
					.Select(s => s.New.AsBoolean())
					.StartWith(e.EntityState.AsBoolean())
			)
			.CombineLatest()
			.Select(r => r.Any(s => s ?? false) as bool?);
	}
}
