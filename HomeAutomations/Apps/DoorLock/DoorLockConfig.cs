using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.DoorLock;

public record DoorLockConfig : Config
{
	public string Token { get; init; }
	public LockEntity LockEntity { get; init; }
	public LockEntity OpenerEntity { get; init; }
	public TimeSpan RtoTimeout { get; init; }
	public TimeSpan RtoTimeoutCheckInterval { get; init; }
	public BinarySensorEntity RingSensor { get; init; }
	public IEnumerable<PersonEntity> EnabledPersons { get; init; }
	public double GpsAccuracyThreshold { get; init; }
	public Notification ArrivalNotification { get; init; }
}
