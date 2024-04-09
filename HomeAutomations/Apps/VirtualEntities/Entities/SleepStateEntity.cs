﻿using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Entities.Converters.Sensors;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities.Entities;

public record SleepStateEntityConfig : VirtualEntityConfig
{
	public TimeSpan DebounceTime { get; init; }
	public IEnumerable<BinarySensorEntity> BedPresenceSensors { get; init; } = Enumerable.Empty<BinarySensorEntity>();

	public IEnumerable<SensorEntity> SmartphoneChargingSensors { get; init; } = Enumerable.Empty<SensorEntity>();
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
		var bedPresenceObservable = CreateThrottledPresenceObservable(
			Config.BedPresenceSensors.Select(x => x.ToObservableState())
		);
		var phoneChargingObservable = CreateThrottledPresenceObservable(
			Config.SmartphoneChargingSensors.Select(x => x.ToObservableState<ChargingSensorEntityStateMap, bool?>())
		);

		return bedPresenceObservable
			.CombineLatest(phoneChargingObservable, (inBed, phoneCharging) => inBed && phoneCharging)
			.DistinctUntilChanged();
	}

	public override string StateToString(bool state) => state.ToOnOff();

	private IObservable<bool> CreateThrottledPresenceObservable(IEnumerable<IObservable<bool?>> observables) =>
		CreatePresenceObservable(observables).EmitDelayed(x => x == false, TimeSpan.FromMinutes(5));

	private IObservable<bool> CreatePresenceObservable(IEnumerable<IObservable<bool?>> observables) => observables.CombineLatest(x => x.Any(y => y ?? false));
}
