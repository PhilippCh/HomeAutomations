namespace HomeAutomations.Apps.DoorLock.Nuki;

public record NukiCallback
{
	public int NukiId { get; init; }
	public int DeviceType { get; init; }
	public int Mode { get; init; }
	public int State { get; init; }
	public string StateName { get; init; }
	public bool BatteryCritical { get; init; }
	public bool BatteryCharging { get; init; }
	public int BatteryChargeState { get; init; }
	public int DoorSensorState { get; init; }
	public string DoorSensorStateName { get; init; }
}
