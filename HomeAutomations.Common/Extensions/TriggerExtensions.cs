using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Common.Extensions;

public static class TriggerExtensions
{
	/// <summary>
	/// Switches between start and end. When start emits, it waits for end to emit and then switches back to start again.
	/// </summary>
	/// <param name="start">Start trigger</param>
	/// <param name="end">End trigger</param>
	/// <param name="initialState">Override initial state (useful when restarting net-daemon while between start and end)</param>
	/// <returns>Trigger observable</returns>
	public static IObservable<bool> WithEnd(this ITrigger start, ITrigger end, ActiveTriggerState initialState = ActiveTriggerState.Start)
	{
		var activeTriggerState = new BehaviorSubject<ActiveTriggerState>(initialState);
		var result = new BehaviorSubject<bool>(false);

		// This observable begins with the start trigger and switches on the following conditions:
		// 1. The start trigger is active and the end trigger becomes active (Start -> End)
		// 2. The end trigger is active and the start trigger becomes active (End -> Start)
		//
		// This ensures a correct trigger order and start/end not being triggered twice or in the wrong order on weekends/during special cases.
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
