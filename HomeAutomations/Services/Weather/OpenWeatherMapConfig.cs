namespace HomeAutomations.Services.Weather;

public record OpenWeatherMapConfig
{
	public string BaseUrl { get; init; }
	public string ApiKey { get; init; }
}
