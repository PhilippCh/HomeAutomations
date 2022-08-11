namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;

public class GetConnectionsAtCommand : AtCommand
{
	public override string CommandString => "AT+GETCONN";
}
