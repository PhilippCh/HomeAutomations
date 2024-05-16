namespace HomeAutomations.Services.Weather;

public record WeatherServiceConfig
{
	public string BaseUrl { get; init; }
	public string ApiKey { get; init; }
	public TimeSpan UpdateInterval { get; init; }
}
