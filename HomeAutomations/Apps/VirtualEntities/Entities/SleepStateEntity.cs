using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Apps.Lights.ScheduledLights;
using HomeAutomations.Entities.Converters.Sensors;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities.Entities;

public record SleepStateEntityConfig
{
	public TimeSpan DebounceTime { get; init; }
	public TimeConfig SleepTimeEnd { get; init; }
	public IEnumerable<BinarySensorEntity> BedPresenceSensors { get; init; }

	public IEnumerable<SensorEntity> SmartphoneChargingSensors { get; init; }
}

public class SleepStateEntity : VirtualEntity<bool, SleepStateEntityConfig>
{
	public SleepStateEntity(string id, SleepStateEntityConfig config, IMqttEntityManager entityManager, ILogger logger)
		: base(config, entityManager, logger)
	{
		Id = id;
	}

	public override IObservable<bool> StateChanges()
	{
		var bedPresenceStates = CreatePresenceObservable(
			Config.BedPresenceSensors.Select(x => x.ToObservableState())
		);
		var smartphoneChargingStates = CreatePresenceObservable(
			Config.SmartphoneChargingSensors.Select(x => x.ToObservableState<ChargingSensorEntityStateMap, bool?>())
		);
		var allStates = bedPresenceStates.CombineLatest(smartphoneChargingStates);

		return allStates.Select(
			x =>
			{
				var sleepTimeEnd = Config.SleepTimeEnd.GetActualTime(AppConstants.Latitude, AppConstants.Longitude);
				var hasSleepTimeEnded = DateTime.Now >= sleepTimeEnd;
				var isAnyoneInBed = x.First || x.Second;

				Logger.Information(
					"Has sleep time ended?: {HasSleepTimeEnded} | Bed Presence?: {BedPresence} | Phones charging?: {PhonesCharging}",
					hasSleepTimeEnded, x.First, x.Second
				);

				return !(hasSleepTimeEnded && !isAnyoneInBed);
			});
	}

	public override string StateToString(bool state) => state.ToOnOff();

	private IObservable<bool> CreatePresenceObservable(IEnumerable<IObservable<bool?>> observables)
	{
		return observables.CombineLatest(x => x.Any(y => y ?? false))
			.Throttle(Config.DebounceTime);
	}
}
