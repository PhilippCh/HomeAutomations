using System.Collections.Generic;
using System.Reactive.Concurrency;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Services;

namespace HomeAutomations.Triggers;

public class TimeTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public TimeOnly From { get; init; }
	public TimeOnly To { get; init; }

	private readonly IScheduler? _scheduler;
	private readonly IClockService? _clockService;

	/// <summary>
	/// Default constructor for JSON deserialization.
	/// </summary>
	public TimeTrigger()
	{
	}

	/// <summary>
	/// Constructor for unit/integration tests.
	/// </summary>
	/// <param name="scheduler">The custom scheduler</param>
	/// <param name="clockService"></param>
	public TimeTrigger(IScheduler scheduler, IClockService clockService)
	{
		_scheduler = scheduler;
		_clockService = clockService;
	}

	public IObservable<bool> AsObservable() =>
		Observable
			.Interval(TimeSpan.FromMinutes(1), _scheduler ?? Scheduler.Default)
			.StartWith(0)
			.Select(
				_ =>
				{
					var currentTime = (_clockService?.Now ?? DateTime.Now).TimeOfDay;

					return currentTime >= From.ToTimeSpan() && currentTime < To.ToTimeSpan();
				})
			.Do(x => LatestValue = x)
			.DistinctUntilChanged();

	public IEnumerable<ITrigger> GetTriggersInternal() => [];
}
