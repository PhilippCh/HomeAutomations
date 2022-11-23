using HomeAutomations.Common.Services.Bluetooth.Commands.Commands;
using HomeAutomations.Common.Services.Bluetooth.Commands.Events;
using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;

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
		if (Data?.Address == null)
		{
			return;
		}

		var gapConnectCommands = atCommandService.FindByCommandString<GapConnectAtCommand>(Data.Address).ToList();

		if (gapConnectCommands.Count > 1)
		{
			Logger.Warning("Found {Count} GapConnect commands for {Address}", gapConnectCommands.Count, Data.Address);

			return;
		}

		gapConnectCommands.First().OnConnectionEstablished(this);
	}
}
