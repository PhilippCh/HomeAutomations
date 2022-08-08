namespace HomeAutomations.Common.Models.Config;

public record BluetoothServiceConfig : Config
{
	public string Port { get; init; }
}
