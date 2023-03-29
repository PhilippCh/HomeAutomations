using System.Collections.Generic;
using HomeAutomations.Apps.ComputerSwitches;
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
	public BinarySensorEntity RingSensor { get; init; }
	public Notification ArrivalNotification { get; init; }
}
