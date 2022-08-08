using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services.Bluetooth;

namespace HomeAutomations.Apps.Scales.KitchenScaleNew;

public record KitchenScaleNewConfig : Config
{
	public BluetoothConnectionInfo Scale { get; init; }
}
