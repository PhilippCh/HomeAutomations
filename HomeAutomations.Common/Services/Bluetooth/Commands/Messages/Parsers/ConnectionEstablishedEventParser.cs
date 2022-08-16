using System.Text.RegularExpressions;
using HomeAutomations.Common.Services.Bluetooth.Commands.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Parsers;

[UsedImplicitly]
public class ConnectionEstablishedEventParser : ICustomMessageParser
{
	private readonly Regex _messageReplaceRegex = new("{(?<eventId>\\d{3}):\"(?<connectionId>\\d*)\",(?<data>.*?)(})$");

	public bool CanFormat(string? message) => message != null && message.StartsWith("{256:") && message.Contains(",{");

	public IAtResult? Format(string? message)
	{
		if (message == null)
		{
			return null;
		}

		var match = _messageReplaceRegex.Match(message);

		if (!match.Success)
		{
			return null;
		}

		var eventCode = int.TryParse(match.Groups[EventConstants.EventIdToken].Value, out var eventCodeInt) ? (EventCode) eventCodeInt : EventCode.Unknown;
		var result = new ConnectionEstablishedEvent
		{
			EventCode = eventCode,
			ConnectionId = match.Groups[EventConstants.ConnectionIdToken].Value,
			Data = JsonConvert.DeserializeObject<ConnectionEstablishedEventData>(match.Groups["data"].Value)
		};

		return result;
	}
}
