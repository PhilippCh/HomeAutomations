using HomeAutomations.Common.Models.Config;

namespace HomeAutomations.Common.Services.Bluetooth;

public record BluetoothServiceConfig : Config
{
	public string Port { get; init; }
}
