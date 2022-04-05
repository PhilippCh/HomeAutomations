using System.Globalization;

namespace HomeAutomations.Common.Extensions;

public static class DateTimeExtensions
{
	public static int AsIso8601WeekOfYear(this DateTime time)
	{
		// Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll
		// be the same week# as whatever Thursday, Friday or Saturday are,
		// and we always get those right
		var day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
		if (day is >= DayOfWeek.Monday and <= DayOfWeek.Wednesday)
		{
			time = time.AddDays(3);
		}

		// Return the week of our adjusted day
		return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
	}
}
