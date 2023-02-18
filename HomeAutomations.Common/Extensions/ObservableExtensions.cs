using System.Reactive.Linq;
using CoordinateSharp;

namespace HomeAutomations.Common.Extensions;

public static class ObservableExtensions
{
	public static IObservable<TResult> SwitchMap<TIn, TResult>(this IObservable<TIn> observable, Func<TIn, IObservable<TResult>> selector) => observable.Select(selector).Switch();

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
