using System.Collections.Generic;
using CoordinateSharp;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LightsSchedule;

public record TimeConfig
{
	public string Hour { get; init; } = string.Empty;
	public string? HourWeekend { get; init; }

	public DateTime? GetActualTime(double latitude, double longitude)
	{
		var date = DateTime.Now;
		var actualHour = date.IsWeekend() ? HourWeekend : Hour;

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
		var location = new Coordinate(latitude, longitude, date);

		return actualHour switch
		{
			"sunrise" => location.CelestialInfo.SunRise,
			"sunset" => location.CelestialInfo.SunSet,
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
	public IReadOnlyList<IEnumerable<LightEntity>> EntityCycles { get; init; }
}

public record LightsScheduleConfig : Config
{
	public double Latitude { get; init; }
	public double Longitude { get; init; }
	public TimeSpan UpdateInterval { get; init; }
	public IEnumerable<CycleConfig> LightCycles { get; init; }
}
