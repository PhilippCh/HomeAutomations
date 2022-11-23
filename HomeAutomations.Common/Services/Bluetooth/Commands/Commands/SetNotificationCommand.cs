using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Commands;

public class SetNotificationCommand : AtCommand
{
	public override string CommandString => $"AT+SETNOTI={_characteristicId}";

	private readonly string _characteristicId;

	public SetNotificationCommand(string characteristicId)
	{
		_characteristicId = characteristicId;
	}

	public override void ProcessEndResult(AtCommandService commandService, EndAtResultMessage result)
	{
		// Do not automatically complete the observable, because we are listening for notifications until we disconnect.
	}

	public void OnValueNotificationReceived(ValueNotificationReceivedEvent e)
	{
		Value(e);
	}
}
