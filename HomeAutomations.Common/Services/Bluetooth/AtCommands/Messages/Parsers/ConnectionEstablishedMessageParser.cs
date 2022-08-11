using System.Text.RegularExpressions;
using HomeAutomations.Common.Services.Bluetooth.AtCommands.Events;
using HomeAutomations.Common.Services.Bluetooth.AtCommands.Messages.Events;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Messages;

[UsedImplicitly]
public class ConnectionEstablishedMessageParser : ICustomMessageParser
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

		var obj = new JObject
		{
			{ EventConstants.EventIdToken, new JValue(match.Groups[EventConstants.EventIdToken].Value) },
			{ EventConstants.ConnectionIdToken, new JValue(match.Groups[EventConstants.ConnectionIdToken].Value) },
			{ EventConstants.DataToken, JObject.Parse(match.Groups["data"].Value) }
		};

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
