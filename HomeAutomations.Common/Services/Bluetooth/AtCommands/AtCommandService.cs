using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class AtCommandService
{
	private readonly Queue<IAtResult> _messages = new();
	private readonly Queue<string> _pendingCommands = new();
	private readonly AtCommandParser _atCommandParser = new();

	public void BeginCommand(string command)
	{
		Console.WriteLine($"Beginning command {command}");
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

	private void ProcessMessages()
	{
	}
}
