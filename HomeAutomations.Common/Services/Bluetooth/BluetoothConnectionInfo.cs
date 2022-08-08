namespace HomeAutomations.Common.Services.Bluetooth;

public enum BluetoothAddressType
{
	Public = 0,
	Private = 1
}

public record BluetoothConnectionInfo
{
	public BluetoothAddressType AddressType { get; init; }
	public string Id { get; init; }

	public override string ToString()
	{
		return $"[{(int) AddressType}]{Id}";
	}
}
