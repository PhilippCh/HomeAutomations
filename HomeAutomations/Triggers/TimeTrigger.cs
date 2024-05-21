using System.Reactive.Concurrency;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Triggers;

public class TimeTrigger : ITrigger
{
	public string? Id { get; init; }
	public TimeOnly Time { get; init; }

	private readonly IScheduler? _scheduler;

	/// <summary>
	/// Default constructor for JSON deserialization.
	/// </summary>
	public TimeTrigger()
	{
	}

	/// <summary>
	/// If you want to use a custom scheduler (e.g. for testing), you can use this constructor.
	/// </summary>
	/// <param name="scheduler">The custom scheduler</param>
	public TimeTrigger(IScheduler scheduler)
	{
		_scheduler = scheduler;
	}

	public IObservable<bool> AsObservable() =>
		Observable
			.Interval(TimeSpan.FromMinutes(1), _scheduler ?? Scheduler.Default)
			.Select(_ => DateTime.Now.TimeOfDay > Time.ToTimeSpan())
			.DistinctUntilChanged();
}
