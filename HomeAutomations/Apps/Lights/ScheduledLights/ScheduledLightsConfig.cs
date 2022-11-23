using System.Collections.Generic;
using CoordinateSharp;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Extensions;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public record TimeConfig
{
	public string Hour { get; init; } = string.Empty;
	public string? HourWeekend { get; init; }

	public DateTime? GetActualTime(double latitude, double longitude)
	{
		var date = DateTime.Now;
		var actualHour = date.IsWeekend() ? HourWeekend ?? Hour : Hour;

		try
		{
			return date.Date.Add(TimeSpan.Parse(actualHour!));
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

public record CycleConfig
{
	public string Name { get; init; }
	public TimeConfig Start { get; init; }
	public TimeConfig End { get; init; }
	public TimeSpan? Interval { get; init; }
	public IReadOnlyList<IEnumerable<Entity>> EntityCycles { get; init; }
}

public record ScheduledLightsConfig : Config
{
	public double Latitude { get; init; }
	public double Longitude { get; init; }
	public TimeSpan UpdateInterval { get; init; }
	public IEnumerable<CycleConfig> LightCycles { get; init; }
}
