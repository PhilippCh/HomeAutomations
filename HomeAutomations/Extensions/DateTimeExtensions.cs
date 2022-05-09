namespace HomeAutomations.Extensions;

public static class DateTimeExtensions
{
	public static bool IsWeekend(this DateTime dateTime) => dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
}
