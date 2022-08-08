using System.Text.Json;

namespace HomeAutomations.Common.Services.Bluetooth;

public class AtCommandService
{
	private readonly Queue<JsonDocument> _messages = new();
	private readonly Queue<string> _pendingCommands = new();

	public void BeginCommand(string command)
	{
		Console.WriteLine($"Beginning command {command}");
	}

	public void AddMessages(IEnumerable<JsonDocument?> messages)
	{
		foreach (var message in messages.Where(m => m != null))
		{
			_messages.Enqueue(message!);
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
