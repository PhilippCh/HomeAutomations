using System.Text.Json.Serialization;

namespace HomeAutomations.Services.Weather;

public record WeatherResponse
{
	[JsonPropertyName("wind_speed")]
	public double WindSpeed { get; init; }

	[JsonPropertyName("wind_gust")]
	public double WindGust { get; init; }
}

public record OpenWeatherMapResponse
{
	[JsonPropertyName("current")]
	public WeatherResponse Current { get; init; }

	[JsonPropertyName("humidity")]
	public int Humidity { get; init; }
}
