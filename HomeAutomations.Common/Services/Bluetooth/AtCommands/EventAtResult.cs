using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

[JsonConverter(typeof(EventAtResultJsonConverter))]
public class EventAtResult : IAtResult
{
	public int Id { get; set; }

	public JObject? Data { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
		atCommandService.OnEventResultReceived(this);
	}
}

public class EventAtResultJsonConverter : JsonConverter
{
	private static readonly int[] EventCodes =
	{
		256, 258, 260, 263, 264, 265, 266, 268, 269, 271, 272, 273, 276, 278, 279, 768, 769, 770, 771, 772, 773, 774, 775, 776, 777, 778
	};

	public override bool CanRead => true;

	public override bool CanWrite => false;

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		throw new NotImplementedException("Can not write with this converter.");
	}

	public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		var eventResult = new EventAtResult();
		var jObject = JObject.Load(reader);
		var eventCodesInObject = jObject.Properties()
			.Where(p => EventCodes.Contains(int.TryParse(p.Name, out var id) ? id : -1));

		return eventResult;
	}

	public override bool CanConvert(Type objectType) => objectType == typeof(ResponseAtResult);
}
