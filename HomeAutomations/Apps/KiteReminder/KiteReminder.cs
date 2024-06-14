using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using HomeAutomations.Services.Weather;

namespace HomeAutomations.Apps.KiteReminder;


public class KiteReminder(
	BaseAutomationDependencyAggregate<KiteReminder, KiteReminderConfig> aggregate,
	INotificationService notificationService,
	IWeatherService weatherService) : BaseAutomation<KiteReminder, KiteReminderConfig>(aggregate)
{
	// To convert from m/s to km/h.
	private const double WindSpeedConversionFactor = 3.6;

	private DateTime? _lastNotificationDate;

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		weatherService.LatestWeather.Subscribe(CheckWeatherConditions);
		CronjobExtensions.ScheduleJob(Config.ResetCrontab, Reset, false, cancellationToken);

		return Task.CompletedTask;
	}

	private void CheckWeatherConditions(WeatherDetails? weather)
	{
		if (weather == null)
		{
			return;
		}

		if (_lastNotificationDate != null)
		{
			return;
		}

		var now = DateTime.Now;
		var windSpeed = Math.Round(weather.WindSpeed * WindSpeedConversionFactor, 1);
		var gustSpeed = Math.Round(weather.WindGust * WindSpeedConversionFactor, 1);
		var shouldFire = windSpeed >= Config.Thresholds.Speed &&
		                 gustSpeed >= Config.Thresholds.GustSpeed &&
		                 now.TimeOfDay >= Config.EnableNotificationTime &&
		                 now.TimeOfDay < Config.DisableNotificationTime &&
		                 now - _lastNotificationDate > Config.NotificationInterval;

		Logger.Debug("Wind speed: {Speed} | Gust speed: {GustSpeed} | Will send notification?: {ShouldFire}", windSpeed, gustSpeed, shouldFire);

		if (shouldFire)
		{
			notificationService.SendNotification(Config.Notification, windSpeed, gustSpeed);
			_lastNotificationDate = DateTime.Now;
		}
	}

	private void Reset()
	{
		_lastNotificationDate = null;
	}
}
