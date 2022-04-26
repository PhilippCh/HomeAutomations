using System.Text.Json.Serialization;

namespace HomeAutomations.Apps.KiteReminder;

public record WindResponse
{
	[JsonPropertyName("speed")]
	public double Speed { get; init; }

	[JsonPropertyName("gust")]
	public double GustSpeed { get; init; }
}

public record OpenWeatherMapResponse
{
	[JsonPropertyName("wind")]
	public WindResponse Wind { get; init; }
}
