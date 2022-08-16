namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public class AtvAtCommand : AtCommand
{
	public override string CommandString => $"ATV{(_enableVerboseMode ? 1 : 0)}";

	private readonly bool _enableVerboseMode;

	public AtvAtCommand(bool enableVerboseMode)
	{
		_enableVerboseMode = enableVerboseMode;
	}
}
