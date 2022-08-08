using HomeAutomations.Common.Models.Config;
using HomeAutomations.Common.Services.Bluetooth;

namespace HomeAutomations.Apps.Scales.KitchenScaleNew;

public class Scale
{
	private readonly BluetoothConnectionInfo _connectionInfo;

	public Scale(BluetoothConnectionInfo connectionInfo)
	{
		_connectionInfo = connectionInfo;
	}

	private void ScanForDevice()
	{

	}
}
