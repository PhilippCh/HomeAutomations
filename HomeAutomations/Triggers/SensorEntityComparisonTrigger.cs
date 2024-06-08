using System.Collections.Generic;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using HomeAutomations.Triggers.Enums;

namespace HomeAutomations.Triggers;

public class SensorEntityComparisonTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public SensorEntity Entity { get; init; }
	public float Threshold { get; init; }
	public CompareOperator? Operator { get; init; }

	public IObservable<bool> AsObservable()
	{
		if (Operator == null)
		{
			return Observable.Throw<bool>(new NullReferenceException("Comparison is null. It was most likely not set in the trigger configuration."));
		}

		return Entity
			.StateChanges()
			.Select(x => x.New?.State.AsFloat())
			.StartWith(Entity.State.AsFloat())
			.WhereNotNull()
			.Select(Compare)
			.Do(x => LatestValue = x);
	}

	public IEnumerable<ITrigger> GetTriggersInternal() => [];

	private bool Compare(float value) =>
		Operator switch
		{
			CompareOperator.GreaterThan => value > Threshold,
			CompareOperator.LowerThan => value < Threshold,
			_ => false
		};
}
