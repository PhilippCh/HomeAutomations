using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Converters.Sensors;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities.Entities;

public record SleepStateEntityConfig
{
	public IEnumerable<BinarySensorEntity> BedPresenceSensors { get; init; }

	public IEnumerable<SensorEntity> SmartphoneChargingSensors { get; init; }
}

public class SleepStateEntity : VirtualEntity<bool, SleepStateEntityConfig>
{
	public SleepStateEntity(string id, SleepStateEntityConfig config, IMqttEntityManager entityManager)
		: base(config, entityManager)
	{
		Id = id;
	}

	public override IObservable<bool> StateChanges()
	{
		var bedPresenceStates = Config.BedPresenceSensors
			.Select(x => x.ToObservableState());
		var smartphoneChargingStates = Config.SmartphoneChargingSensors
			.Select(x => x.ToObservableState<ChargingSensorEntityStateMap, bool?>());
		var allStates = bedPresenceStates.Concat(smartphoneChargingStates);

		return allStates.CombineLatest().Select(x => x.Any(y => y ?? false));
	}

	public override string StateToString(bool state) => state.ToOnOff();
}
