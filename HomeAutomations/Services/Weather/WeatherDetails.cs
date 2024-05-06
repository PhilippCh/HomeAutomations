namespace HomeAutomations.Services.Weather;

public record WeatherDetails
{
	public int Humidity { get; init; }
	public double WindSpeed { get; init; }
	public double WindGust { get; init; }
}
