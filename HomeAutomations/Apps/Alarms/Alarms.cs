using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Alarms;

public class Alarms(BaseAutomationDependencyAggregate<Alarms, AlarmsConfig> aggregate, INotificationService notificationService)
	: BaseAutomation<Alarms, AlarmsConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var sensor in Config.Sensors)
		{
			sensor.Entity.StateChanges().Subscribe(x => OnSensorStateChanged(sensor, x.Old?.IsOn(), x.New?.IsOn()));
		}

		return Task.CompletedTask;
	}

	private void OnSensorStateChanged(AlarmSensorConfig sensor, bool? oldState, bool? newState)
	{
		if (newState == null)
		{
			Logger.Warning("{EntityId} sensor state is null", sensor.Entity.EntityId);

			return;
		}

		var states = (Old: oldState ?? false, New: newState);
		var notification = states switch
		{
			(false, true) => sensor.OnNotification,
			(true, false) => sensor.OffNotification,
			_ => null
		};

		if (notification != null)
		{
			notificationService.SendNotification(notification);
		}
	}
}
