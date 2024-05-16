using System.Globalization;
using System.Net.Http;
using System.Reactive.Concurrency;
using System.Reactive.Subjects;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
using HomeAutomations.Apps;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Services.Weather;

public interface IWeatherService
{
	IObservable<WeatherDetails?> LatestWeather { get; }
}

public class WeatherService : IWeatherService
{
	public IObservable<WeatherDetails?> LatestWeather => _latestWeather;

	private readonly IOptions<WeatherServiceConfig> _config;
	private readonly BehaviorSubject<WeatherDetails?> _latestWeather = new(default);

	public WeatherService(IOptions<WeatherServiceConfig> config, IScheduler scheduler)
	{
		_config = config;
		scheduler.ScheduleAsync(_config.Value.UpdateInterval, async (_, ct) => await UpdateWeatherAsync());
	}

	private async Task UpdateWeatherAsync()
	{
		var weather = await GetCurrentAsync(AppConstants.Latitude, AppConstants.Longitude);

		if (weather != null)
		{
			_latestWeather.OnNext(weather);
		}
	}

	private async Task<WeatherDetails?> GetCurrentAsync(double latitude, double longitude)
	{
		JsonNode? content;

		try
		{
			var client = new HttpClient();
			var response = await client.GetAsync(GetWeatherRequestUrl(latitude, longitude));
			var contentString = await response.Content.ReadAsStringAsync();
			content = JsonSerializer.Deserialize<JsonNode>(contentString);
		}
		catch (HttpRequestException)
		{
			return null;
		}

		return content == null ? null : new WeatherDetails
		{
			Humidity = content["main"]!["humidity"]!.GetValue<int>(),
			WindSpeed = content["wind"]!["speed"]!.GetValue<double>(),
			WindGust = content["wind"]!["gust"]!.GetValue<double>()
		};
	}

	private string GetWeatherRequestUrl(double latitude, double longitude)
	{
		var builder = new UriBuilder(_config.Value.BaseUrl)
		{
			Port = -1
		};
		var query = HttpUtility.ParseQueryString(builder.Query);
		query["lat"] = latitude.ToString(CultureInfo.InvariantCulture);
		query["lon"] = longitude.ToString(CultureInfo.InvariantCulture);
		query["appid"] = _config.Value.ApiKey;
		builder.Query = query.ToString();

		return builder.ToString();
	}
}
