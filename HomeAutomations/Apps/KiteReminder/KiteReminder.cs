using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using HomeAutomations.Services.Weather;

namespace HomeAutomations.Apps.KiteReminder;

[Focus]
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
		CronjobExtensions.ScheduleJob(Config.CheckCrontab, CheckWeatherConditionsAsync, true, cancellationToken);
		CronjobExtensions.ScheduleJob(Config.ResetCrontab, Reset, false, cancellationToken);

		return Task.CompletedTask;
	}

	private async Task CheckWeatherConditionsAsync()
	{
		var weather = await weatherService.GetCurrentAsync(AppConstants.Latitude, AppConstants.Longitude);

		if (weather == null)
		{
			Logger.Warning("Could not deserialize OpenWeatherMap response");

			return;
		}

		if (_lastNotificationDate != null)
		{
			return;
		}

		var time = DateTime.Now.TimeOfDay;
		var windSpeed = Math.Round(weather.WindSpeed * WindSpeedConversionFactor, 1);
		var gustSpeed = Math.Round(weather.WindGust * WindSpeedConversionFactor, 1);
		var shouldFire = windSpeed >= Config.Thresholds.Speed &&
		                 gustSpeed >= Config.Thresholds.GustSpeed &&
		                 time >= Config.EnableNotificationTime &&
		                 time < Config.DisableNotificationTime;

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
