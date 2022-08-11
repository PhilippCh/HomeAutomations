namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;

public interface IAtCommand
{
	int Id { get; }
	string CommandString { get; }
	IObservable<ResponseAtResult> Observable { get; }

	public void ProcessCommandResult(CommandAtResult result);
	public void ProcessAckResult(AckAtResult result);
	public void ProcessResponseResult(ResponseAtResult result);
	public void ProcessEndResult(EndAtResultMessage result);
}
