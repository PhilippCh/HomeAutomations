using System.Reactive.Linq;
using System.Reactive.Subjects;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class AtCommandMetadata
{
	public string Command { get; set; }
	public int Id { get; set; }
	public Subject<ResponseAtResult> Subject = new();
}

public class AtCommandService
{
	private readonly List<AtCommandMetadata> _atCommandMetadata = new();
	private readonly Queue<IAtResult> _messages = new();
	private readonly AtCommandParser _atCommandParser = new();

	public IObservable<ResponseAtResult> BeginCommand(string command)
	{
		Console.WriteLine($"Beginning command {command}");
		var metadata = new AtCommandMetadata {Command = command};
		_atCommandMetadata.Add(metadata);

		return metadata.Subject.AsObservable();
	}

	public void AddMessages(IEnumerable<JObject?> messages)
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

	public void OnCommandResultReceived(CommandAtResult result)
	{
		var metadata = _atCommandMetadata.FirstOrDefault(m => m.Command == result.Command);

		if (metadata != null)
		{
			metadata.Id = result.Id;
		}
	}

	public void OnEventResultReceived(EventAtResult result)
	{
		var metadata = _atCommandMetadata.FirstOrDefault(m => m.Id == result.Id);
	}

	public void OnResponseResultReceived(ResponseAtResult result)
	{
		var metadata = _atCommandMetadata.FirstOrDefault(m => m.Id == result.Id);

		if (metadata != null)
		{
			metadata.Subject.OnNext(result);
		}
	}

	public void OnEndResultReceived(EndAtResultMessage result)
	{
		var metadata = _atCommandMetadata.FirstOrDefault(m => m.Id == result.Id);

		if (metadata != null)
		{
			metadata.Subject.OnCompleted();
			_atCommandMetadata.Remove(metadata);
		}
	}

	private void ProcessMessages()
	{
		while (_messages.TryDequeue(out var message))
		{
			message.ProcessResult(this);
		}
	}
}
