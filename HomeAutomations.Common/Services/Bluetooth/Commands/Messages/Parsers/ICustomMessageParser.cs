using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Parsers;

public interface ICustomMessageParser
{
	bool CanFormat(string? message);

	IAtResult? Format(string? message);
}
