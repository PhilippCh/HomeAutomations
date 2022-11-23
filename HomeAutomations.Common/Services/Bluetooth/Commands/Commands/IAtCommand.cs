using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public interface IAtCommand
{
	int Id { get; }
	string CommandString { get; }
	IObservable<IAtResult> Observable { get; }

	public void ProcessCommandResult(AtCommandService commandService, CommandAtResult result);
	public void ProcessAckResult(AtCommandService commandService, AckAtResult result);
	public void ProcessResponseResult(AtCommandService commandService, ResponseAtResult result);
	public void ProcessEndResult(AtCommandService commandService, EndAtResultMessage result);
}
