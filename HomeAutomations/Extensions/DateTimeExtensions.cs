namespace HomeAutomations.Extensions;

public static class DateTimeExtensions
{
	public static bool IsWeekend(this DateTime dateTime, bool includeFriday = true) =>
		dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday || (includeFriday && dateTime.DayOfWeek is DayOfWeek.Friday);
}
