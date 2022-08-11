using HomeAutomations.Common.Services.Bluetooth.AtCommands.Events;
using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Messages.Events;

public record ConnectionEstablishedEventData
{
	public string? Action { get; init; }

	[JsonProperty("addr")]
	public string? Address { get; init; }
}

public class ConnectionEstablishedEvent : AtEvent<ConnectionEstablishedEventData>
{
	public override void ProcessResult(AtCommandService atCommandService)
	{

	}
}
