using System.Collections.Generic;
using HomeAutomations.Apps.ComputerSwitches;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.DoorLock;

public record NukiBridgeApiConfig
{
	public string BaseUrl { get; init; }
	public string CallbackUrl { get; init; }
	public string Token { get; init; }
};

public record DoorLockConfig : Config
{
	public NukiBridgeApiConfig BridgeApi { get; init; }
	public string Token { get; init; }
	public LockEntity LockEntity { get; init; }
	public LockEntity OpenerEntity { get; init; }
	public TimeSpan RtoTimeout { get; init; }
}
