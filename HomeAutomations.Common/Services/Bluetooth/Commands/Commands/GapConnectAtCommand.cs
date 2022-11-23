using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public class GapConnectAtCommand : AtCommand
{
	public override string CommandString => $"AT+GAPCONNECT=[{(int) _connectionInfo.AddressType}]{_connectionInfo.Id}";

	private readonly BluetoothConnectionInfo _connectionInfo;

	public GapConnectAtCommand(BluetoothConnectionInfo connectionInfo)
	{
		_connectionInfo = connectionInfo;
	}

	public override void ProcessAckResult(AtCommandService commandService, AckAtResult result)
	{
		if (result.ErrorCode is ErrorCode.AlreadyDone)
		{
			Success(result);
		}
	}

	public override void ProcessResponseResult(AtCommandService commandService, ResponseAtResult result)
	{

	}

	public override void ProcessEndResult(AtCommandService commandService, EndAtResultMessage result)
	{
		// Do not automatically complete the observable, because we could be waiting on a new connection.
	}

	public void OnConnectionEstablished(ConnectionEstablishedEvent e)
	{
		Success(e);
	}
}
