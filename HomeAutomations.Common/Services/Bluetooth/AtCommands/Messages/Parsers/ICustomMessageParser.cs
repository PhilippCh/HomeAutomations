namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Messages;

public interface ICustomMessageParser
{
	bool CanFormat(string? message);

	IAtResult? Format(string? message);
}
