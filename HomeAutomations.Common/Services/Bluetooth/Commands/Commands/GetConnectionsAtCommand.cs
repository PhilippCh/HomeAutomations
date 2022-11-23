namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public class GetConnectionsAtCommand : AtCommand
{
	public override string CommandString => "AT+GETCONN";
}
