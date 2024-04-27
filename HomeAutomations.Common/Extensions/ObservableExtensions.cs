using System.Reactive.Concurrency;
using System.Reactive.Linq;
using CoordinateSharp;

namespace HomeAutomations.Common.Extensions;

public static class ObservableExtensions
{
	public static IObservable<TResult> SwitchMap<TIn, TResult>(this IObservable<TIn> observable, Func<TIn, IObservable<TResult>> selector) => observable.Select(selector).Switch();

	/// <summary>
	/// Emits the filtered values delayed by a specified time, all other values immediately.
	/// </summary>
	public static IObservable<T> EmitDelayed<T>(
		this IObservable<T> observable,
		Func<T, bool> filter,
		TimeSpan filterDelay,
		TimeSpan? defaultDelay = null,
		IScheduler? scheduler = null)
	{
		return observable
			.DistinctUntilChanged() // Only take distinct consecutive elements.
			.Select(
				x => Observable
					.Return(x)
					.Delay(y => Observable.Timer(filter(y) ? filterDelay : defaultDelay ?? TimeSpan.Zero, scheduler ?? Scheduler.Default)) // Wait for delay time.
			)
			.Switch()
			.DistinctUntilChanged();
	}

	public static IObservable<bool> Between(DateTime start, DateTime end, IScheduler? scheduler = null) =>
		Observable.Interval(TimeSpan.FromMinutes(1), scheduler ?? Scheduler.Default)
			.Select(
				_ =>
				{
					var now = DateTime.Now;

					return now >= start && now < end;
				})
			.DistinctUntilChanged();

	public static IObservable<(TSource? Previous, TSource? Current)> PairWithPrevious<TSource>(this IObservable<TSource> source) =>
		source.Scan((default(TSource), default(TSource)), (acc, current) => (acc.Item2, current));

	public static IObservable<int> TryParseInt(this IObservable<string?> observable) =>
		observable.Select(x => (IsSuccess: int.TryParse(x, out var Value), Value))
			.Where(x => x.IsSuccess)
			.Select(x => x.Value);

	public static IObservable<DateTime> IntervalSunset(double latitude, double longitude) =>
		GetIsSunUp(latitude, longitude)
			.Where(x => !x.IsSunUp)
			.Select(x => x.Date);

	public static IObservable<DateTime> IntervalSunrise(double latitude, double longitude) =>
		GetIsSunUp(latitude, longitude)
			.Where(x => x.IsSunUp)
			.Select(x => x.Date);

	private static IObservable<(DateTime Date, bool IsSunUp)> GetIsSunUp(double latitude, double longitude)
	{
		return Observable.Interval(TimeSpan.FromMinutes(1))
			.Select(
				_ =>
				{
					var date = DateTime.Now;
					var utcOffset = TimeZoneInfo.Local.GetUtcOffset(date);
					var celestial = new Celestial(latitude, longitude, date, utcOffset.TotalHours);

					return (Date: date, celestial.IsSunUp);
				})
			.DistinctUntilChanged(x => x.IsSunUp);
	}
}
