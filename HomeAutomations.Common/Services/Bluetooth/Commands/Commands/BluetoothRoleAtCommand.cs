namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public enum BluetoothRole
{
	Dual,
	Central
}

public class BluetoothRoleAtCommand : AtCommand
{
	public override string CommandString => $"AT+{_roles[_role]}";

	private readonly IReadOnlyDictionary<BluetoothRole, string> _roles = new Dictionary<BluetoothRole, string>
	{
		{ BluetoothRole.Dual, "DUAL" },
		{ BluetoothRole.Central, "CENTRAL" }
	};

	private readonly BluetoothRole _role;

	public BluetoothRoleAtCommand(BluetoothRole role)
	{
		_role = role;
	}
}
