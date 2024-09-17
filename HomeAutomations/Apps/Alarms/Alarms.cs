using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Alarms;

[Focus]
public class Alarms(BaseAutomationDependencyAggregate<Alarms, AlarmsConfig> aggregate, INotificationService notificationService)
	: BaseAutomation<Alarms, AlarmsConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var sensor in Config.Sensors)
		{
			sensor.Entity.StateChanges().Subscribe(x => OnSensorStateChanged(sensor, x.Old?.IsOn(), x.New?.IsOn()));
			sensor.BatteryEntity.StateChanges().Subscribe(x => OnBatteryStateChanged(sensor, x.New?.State.AsInt()));
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

	private void OnBatteryStateChanged(AlarmSensorConfig sensor, int? batteryLevel)
	{
		if (batteryLevel == null)
		{
			Logger.Warning("{EntityId} sensor state is null", sensor.BatteryEntity.EntityId);

			return;
		}

		if (batteryLevel > Config.ReplaceBatteryThreshold)
		{
			return;
		}

		if (Config.ReplaceBatteryNotification != null)
		{
			notificationService.SendNotification(Config.ReplaceBatteryNotification, sensor.BatteryEntity.Name);
		}
	}
}
