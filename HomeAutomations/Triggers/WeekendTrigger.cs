using System.Collections.Generic;
using System.Reactive.Concurrency;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Triggers;

public class WeekendTrigger : ITrigger
{
	public string? Id { get; init; }

	private readonly IScheduler? _scheduler;

	/// <summary>
	/// Default constructor for JSON deserialization.
	/// </summary>
	public WeekendTrigger()
	{
	}

	/// <summary>
	/// If you want to use a custom scheduler (e.g. for testing), you can use this constructor.
	/// </summary>
	/// <param name="scheduler">The custom scheduler</param>
	public WeekendTrigger(IScheduler scheduler)
	{
		_scheduler = scheduler;
	}

	public IObservable<bool> AsObservable() =>
		Observable
			.Interval(TimeSpan.FromHours(1), _scheduler ?? Scheduler.Default)
			.StartWith(0)
			.Select(_ => Predicate())
			.DistinctUntilChanged();

	public IEnumerable<ITrigger> GetTriggersInternal() => [];

	private bool Predicate() => DateTime.Now.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
}
