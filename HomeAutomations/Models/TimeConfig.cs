using CoordinateSharp;
using HomeAutomations.Extensions;

namespace HomeAutomations.Models;

public record TimeConfig
{
	public string Hour { get; init; } = string.Empty;
	public string? HourWeekend { get; init; }
	public bool IncludeFriday { get; init; } = true;

	public DateTime? GetActualTime(double latitude, double longitude, DateTime? time = null)
	{
		var date = time ?? DateTime.Now;
		var actualHour = date.IsWeekend(includeFriday: IncludeFriday) ? HourWeekend ?? Hour : Hour;

		try
		{
			return date.Date.Add(TimeSpan.Parse(actualHour));
		}
		catch (Exception)
		{
			return ParseSunTime(latitude, longitude, date, actualHour);
		}
	}

	private static DateTime? ParseSunTime(double latitude, double longitude, DateTime date, string? actualHour)
	{
		var utcOffset = TimeZoneInfo.Local.GetUtcOffset(date);
		var celestial = new Celestial(latitude, longitude, date, utcOffset.TotalHours);

		return actualHour switch
		{
			"sunrise" => celestial.SunRise,
			"sunset" => celestial.SunSet,
			_ => null
		};
	}

	public override string ToString() => $"{Hour} ({HourWeekend} on weekends)";
}
