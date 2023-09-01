using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Constants;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.InternetWatchdog;

[Focus]
public class InternetWatchdog : BaseAutomation<InternetWatchdog, InternetWatchdogConfig>
{
	private readonly NotificationService _notificationService;

	public InternetWatchdog(BaseAutomationDependencyAggregate<InternetWatchdog, InternetWatchdogConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Config.SensorEntity.StateChanges().Subscribe(x => OnSensorStateChanged(x.Old?.State, x.New?.State));

		OnSensorStateChanged(null, Config.SensorEntity.State);

		return Task.CompletedTask;
	}

	private void OnSensorStateChanged(string? oldState, string? newState)
	{
		if (string.IsNullOrEmpty(newState))
		{
			return;
		}

		if (oldState != newState && newState == EntityStates.Unavailable)
		{
			// Internet is down, send notification.
			_notificationService.SendNotification(Config.InternetDownNotification);
		}

		if (oldState != newState && newState != EntityStates.Unavailable)
		{
			// Internet is back up, send notification.
			Logger.Information("Old: {OldState} | New: {NewState}", oldState, newState);
			_notificationService.SendNotification(Config.InternetUpNotification);
		}
	}
}
