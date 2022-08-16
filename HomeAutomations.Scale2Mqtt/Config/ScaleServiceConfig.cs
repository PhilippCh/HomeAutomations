using HomeAutomations.Common.Services.Bluetooth;

namespace HomeAutomations.Scale2Mqtt.Config;

public record ScaleServiceConfig : Common.Models.Config.Config
{
	public BluetoothConnectionInfo ConnectionInfo { get; init; }
	public string MeasurementCharacteristicId { get; init; }
	public string Topic { get; init; }
	public TimeSpan DisconnectTimeout { get; init; }
}
