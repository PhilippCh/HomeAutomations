using System.Dynamic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Services.Weather;

public interface IWeatherService
{
	Task<WeatherDetails?> GetCurrentAsync(double latitude, double longitude);
}

public class WeatherService(IOptions<OpenWeatherMapConfig> config) : IWeatherService
{
	public async Task<WeatherDetails?> GetCurrentAsync(double latitude, double longitude)
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
		var builder = new UriBuilder(config.Value.BaseUrl)
		{
			Port = -1
		};
		var query = HttpUtility.ParseQueryString(builder.Query);
		query["lat"] = latitude.ToString(CultureInfo.InvariantCulture);
		query["lon"] = longitude.ToString(CultureInfo.InvariantCulture);
		query["appid"] = config.Value.ApiKey;
		builder.Query = query.ToString();

		return builder.ToString();
	}
}
