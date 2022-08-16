using HomeAutomations.Common.Services.Bluetooth.Commands.Commands;
using HomeAutomations.Common.Services.Bluetooth.Commands.Events;
using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;

public record ValueNotificationReceivedEventData
{
	public string? CharacteristicId { get; init; }

	[JsonProperty("hex")]
	public string? Hex { get; init; }
}

public class ValueNotificationReceivedEvent : AtEvent<ValueNotificationReceivedEventData>
{
	public override void ProcessResult(AtCommandService atCommandService)
	{
		if (Data?.CharacteristicId == null)
		{
			return;
		}

		var setNotificationCommands = atCommandService.FindByCommandString<SetNotificationCommand>($"SETNOTI={Data.CharacteristicId}").ToList();

		if (!setNotificationCommands.Any() || setNotificationCommands.Count > 1)
		{
			Logger.Warning("Found {Count} SetNotification commands for {CharacteristicId}", setNotificationCommands.Count, Data.CharacteristicId);

			return;
		}

		setNotificationCommands.First().OnValueNotificationReceived(this);
	}
}
