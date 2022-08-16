using System.Text.RegularExpressions;
using HomeAutomations.Common.Services.Bluetooth.Commands.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Events;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Parsers;

[UsedImplicitly]
public class ValueNotificationReceivedEventParser : ICustomMessageParser
{
	private readonly Regex _messageReplaceRegex = new("{(?<eventId>\\d*):\"(?<connectionId>\\d*)\",\"(?<characteristicId>\\d*)\":(?<data>.*?)(})$");

	public bool CanFormat(string? message) => message != null && message.StartsWith("{777:") && message.Contains("\"hex\":");

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

		try
		{
			var data = JObject.Parse(match.Groups["data"].Value);
			data.Add(EventConstants.CharacteristicIdToken, new JValue(match.Groups[EventConstants.CharacteristicIdToken].Value));
			var obj = new JObject
			{
				{ EventConstants.EventIdToken, new JValue(match.Groups[EventConstants.EventIdToken].Value) },
				{ EventConstants.ConnectionIdToken, new JValue(match.Groups[EventConstants.ConnectionIdToken].Value) },
				{ EventConstants.DataToken, data }
			};

			return obj.ToObject<ValueNotificationReceivedEvent>();
		}
		catch (Exception)
		{
			return null;
		}
	}
}
