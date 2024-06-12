using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text.Json;
using System.Threading;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Models;

namespace HomeAutomations.Extensions;

public record HaEvent(Event e)
{
	public string? Action => e.DataElement?.GetProperty("action").GetString();

	public T? GetData<T>(string key)
	{
		if (!(e.DataElement?.TryGetProperty(key, out var property) ?? false))
		{
			return default;
		}

		return property.Deserialize<T>();
	}
}

public static class ObservableExtensions
{
	public static IObservable<HaEvent> GetDataEvents(this IObservable<Event> events, string eventId) =>
		events
			.Where(e => e.EventType == eventId && e.DataElement.HasValue)
			.Select(e => new HaEvent(e));

	public static IObservable<string> GetMobileAppNotificationActions(this IObservable<Event> events, IEnumerable<string> allowedActions) =>
		events
			.GetDataEvents(MobileAppNotificationData.Id)
			.Where(x => allowedActions.Contains(x.Action))
			.Select(x => x.Action!);

	public static IObservable<MobileAppActionEvent> GetMobileAppActions(this IObservable<Event> events, IEnumerable<string> allowedActions) =>
		events
			.Filter<MobileAppActionEvent>(EventConstants.IosActionFired)
			.Where(x => allowedActions.Contains(x.Data?.ActionName))
			.Select(x => x.Data!);

	public static IObservable<long> Interval(TimeSpan interval, bool emitImmediately = false)
	{
		var observable = Observable.Interval(interval);

		return emitImmediately ? observable.StartWith(-1) : observable;
	}

	public static IObservable<T> ThrottleFirst<T>(
		this IObservable<T> source,
		TimeSpan timespan,
		IScheduler timeSource)
	{
		return new ThrottleFirstObservable<T>(source, timeSource, timespan);
	}

	public static IObservable<T> WhereNotNull<T>(this IObservable<T?> source) where T : struct => source.Where(i => i.HasValue).Select(i => i!.Value);

	sealed class ThrottleFirstObservable<T> : IObservable<T>
	{
		readonly IObservable<T> source;
		readonly IScheduler timeSource;
		readonly TimeSpan timespan;

		internal ThrottleFirstObservable(
			IObservable<T> source,
			IScheduler timeSource,
			TimeSpan timespan)
		{
			this.source = source;
			this.timeSource = timeSource;
			this.timespan = timespan;
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			var parent = new ThrottleFirstObserver(observer, timeSource, timespan);
			var d = source.Subscribe(parent);
			parent.OnSubscribe(d);

			return d;
		}

		sealed class ThrottleFirstObserver : IDisposable, IObserver<T>
		{
			readonly IObserver<T> downstream;

			readonly IScheduler timeSource;

			readonly TimeSpan timespan;

			IDisposable upstream;

			bool once;

			double due;

			internal ThrottleFirstObserver(
				IObserver<T> downstream,
				IScheduler timeSource,
				TimeSpan timespan)
			{
				this.downstream = downstream;
				this.timeSource = timeSource;
				this.timespan = timespan;
			}

			public void OnSubscribe(IDisposable d)
			{
				if (Interlocked.CompareExchange(ref upstream, d, null) != null)
				{
					d.Dispose();
				}
			}

			public void Dispose()
			{
				var d = Interlocked.Exchange(ref upstream, this);
				if (d != null && d != this)
				{
					d.Dispose();
				}
			}

			public void OnCompleted()
			{
				downstream.OnCompleted();
			}

			public void OnError(Exception error)
			{
				downstream.OnError(error);
			}

			public void OnNext(T value)
			{
				var now = timeSource.Now.ToUnixTimeMilliseconds();
				if (!once)
				{
					once = true;
					due = now + timespan.TotalMilliseconds;
					downstream.OnNext(value);
				}
				else if (now >= due)
				{
					due = now + timespan.TotalMilliseconds;
					downstream.OnNext(value);
				}
			}
		}
	}
}
