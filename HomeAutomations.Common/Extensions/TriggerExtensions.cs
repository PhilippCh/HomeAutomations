using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Common.Extensions;

public static class TriggerExtensions
{
	public static IObservable<bool> WithEnd(this ITrigger start, ITrigger end)
	{
		var activeTriggerState = new BehaviorSubject<ActiveTriggerState>(ActiveTriggerState.Start);
		var result = new BehaviorSubject<bool>(false);

		activeTriggerState
			.SwitchMap(
				x =>
				{
					var nextTriggerState = x == ActiveTriggerState.Start ? ActiveTriggerState.End : ActiveTriggerState.Start;
					var currentObservable = x == ActiveTriggerState.Start ? start : end;

					return currentObservable
						.AsObservable()
						.Where(y => y)
						.Do(
							_ =>
							{
								result.OnNext(x == ActiveTriggerState.Start);
								activeTriggerState.OnNext(nextTriggerState);
							});
				})
			.Subscribe();

		return result;
	}
}
