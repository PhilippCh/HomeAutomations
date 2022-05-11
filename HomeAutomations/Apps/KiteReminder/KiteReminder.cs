using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.KiteReminder;

public class KiteReminder : BaseAutomation<KiteReminder, KiteReminderConfig>
{
	// To convert from m/s to km/h.
	private const double WindSpeedConversionFactor = 3.6;

	private DateTime? _lastNotificationDate;

	private readonly NotificationService _notificationService;

	public KiteReminder(BaseAutomationDependencyAggregate<KiteReminder, KiteReminderConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		CronjobExtensions.ScheduleJob(Config.CheckCrontab, CheckWeatherConditions, true, cancellationToken);
		CronjobExtensions.ScheduleJob(Config.ResetCrontab, Reset, false, cancellationToken);

		return Task.CompletedTask;
	}

	private async void CheckWeatherConditions()
	{
		var client = new HttpClient();
		var response = await client.GetAsync(GetWeatherRequestUrl());
		var weather = await response.Content.ReadFromJsonAsync<OpenWeatherMapResponse>();

		if (weather == null)
		{
			Logger.Warning("Could not deserialize OpenWeatherMap response");

			return;
		}

		if (_lastNotificationDate != null)
		{
			return;
		}

		var windSpeed = Math.Round(weather.Wind.Speed * WindSpeedConversionFactor, 1);
		var gustSpeed = Math.Round(weather.Wind.GustSpeed * WindSpeedConversionFactor, 1);
		var shouldFire = windSpeed >= Config.Thresholds.Speed && gustSpeed >= Config.Thresholds.GustSpeed;

		Logger.Information("Wind speed: {Speed} | Gust speed: {GustSpeed} | Will send notification?: {ShouldFire}", windSpeed, gustSpeed, shouldFire);

		if (shouldFire)
		{
			var notification = Config.Notification with { Template = Config.Notification.RenderTemplate(windSpeed, gustSpeed) };
			_notificationService.SendNotification(notification);
			_lastNotificationDate = DateTime.Now;
		}
	}

	private void Reset()
	{
		_lastNotificationDate = null;
	}

	private string GetWeatherRequestUrl()
	{
		var builder = new UriBuilder(Config.OpenWeatherMap.BaseUrl)
		{
			Port = -1
		};
		var query = HttpUtility.ParseQueryString(builder.Query);
		query["lat"] = Config.Latitude.ToString(CultureInfo.InvariantCulture);
		query["lon"] = Config.Longitude.ToString(CultureInfo.InvariantCulture);
		query["appid"] = Config.OpenWeatherMap.ApiKey;
		builder.Query = query.ToString();

		return builder.ToString();
	}
}
