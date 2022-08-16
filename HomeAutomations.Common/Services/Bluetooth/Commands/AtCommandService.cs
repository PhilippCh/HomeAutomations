using HomeAutomations.Common.Services.Bluetooth.Commands.Commands;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands;

public class AtCommandService : BaseService<AtCommandService>
{
	private readonly List<IAtCommand> _atCommands = new();
	private readonly Queue<IAtResult> _messages = new();
	private readonly AtCommandParser _atCommandParser = new();

	public AtCommandService(BaseServiceDependencyAggregate<AtCommandService> aggregate)
		: base(aggregate)
	{
	}

	public IObservable<IAtResult> BeginCommand(IAtCommand command)
	{
		Logger.Information("Beginning command {Command}", command);
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

	public IEnumerable<T> FindByCommandString<T>(string commandString) where T : IAtCommand
	{
		return _atCommands
			.OfType<T>()
			.Where(c => c.CommandString.ToLowerInvariant().Contains(commandString.ToLowerInvariant()));
	}

	public void OnCommandResultReceived(CommandAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.CommandString == result.Command);
		command?.ProcessCommandResult(this, result);
	}

	public void OnAckResultReceived(AckAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessAckResult(this, result);
	}

	public void OnResponseResultReceived(ResponseAtResult result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessResponseResult(this, result);
	}

	public void OnEndResultReceived(EndAtResultMessage result)
	{
		var command = _atCommands.FirstOrDefault(m => m.Id == result.Id);
		command?.ProcessEndResult(this, result);
	}

	public void RemoveCommand(AtCommand command)
	{
		_atCommands.Remove(command);
	}

	private void ProcessMessages()
	{
		while (_messages.TryDequeue(out var message))
		{
			message.ProcessResult(this);
		}
	}
}
