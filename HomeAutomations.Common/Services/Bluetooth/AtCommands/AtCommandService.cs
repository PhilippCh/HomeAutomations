using HomeAutomations.Common.Services.Bluetooth.AtCommands.Commands;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class AtCommandService
{
	private readonly List<IAtCommand> _atCommands = new();
	private readonly Queue<IAtResult> _messages = new();
	private readonly AtCommandParser _atCommandParser = new();

	public IObservable<ResponseAtResult> BeginCommand(IAtCommand command)
	{
		Console.WriteLine($"Beginning command {command}");
		_atCommands.Add(command);

		return command.Observable;
	}

	public void AddMessages(IEnumerable<string?> messages)
	{
		var parsedMessages = messages
			.Select(m => _atCommandParser.Parse(m))
			.Where(m => m != null)
			.Select(m => m!);

		foreach (var message in parsedMessages)
		{
			_messages.Enqueue(message);
		}

		if (_messages.Any())
		{
			ProcessMessages();
		}
	}

	public IEnumerable<T> FindByCommandString<T>(string commandString) where T: IAtCommand
	{
		return _atCommands
			.OfType<T>()
			.Where(c => c.CommandString.Contains(commandString));
	}

	public void OnCommandResultReceived(CommandAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.CommandString == result.Command);
		command?.ProcessCommandResult(result);
	}

	public void OnAckResultReceived(AckAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessAckResult(result);
	}

	public void OnResponseResultReceived(ResponseAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessResponseResult(result);
	}

	public void OnEndResultReceived(EndAtResultMessage result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessEndResult(result);

		if (command != null)
		{
			_atCommands.Remove(command);
		}
	}

	public void OnEventResultReceived(UnknownAtResult result)
	{
		//var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
	}

	private void ProcessMessages()
	{
		while (_messages.TryDequeue(out var message))
		{
			message.ProcessResult(this);
		}
	}
}
