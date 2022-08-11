namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;

public class GapConnectAtCommand : AtCommand
{
	public override string CommandString => $"AT+GAPCONNECT=[{(int) _connectionInfo.AddressType}]{_connectionInfo.Id}";

	private readonly BluetoothConnectionInfo _connectionInfo;

	public GapConnectAtCommand(BluetoothConnectionInfo connectionInfo)
	{
		_connectionInfo = connectionInfo;
	}

	public override void ProcessAckResult(AckAtResult result)
	{
		if (result.ErrorCode is ErrorCode.Success or ErrorCode.AlreadyDone)
		{
			Success();
		}
	}

	public override void ProcessResponseResult(ResponseAtResult result)
	{

	}

	public override void ProcessEndResult(EndAtResultMessage result)
	{
		// Do not automatically complete the observable, because we could be waiting on a new connection.
	}
}
