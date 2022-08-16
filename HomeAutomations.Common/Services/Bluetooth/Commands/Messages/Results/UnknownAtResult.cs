using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

[JsonConverter(typeof(UnknownAtResultJsonConverter))]
public class UnknownAtResult : IAtResult
{
	public JObject? Data { get; set; }
	public string? RawData { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
	}
}

public class UnknownAtResultJsonConverter : JsonConverter
{
	public override bool CanRead => true;

	public override bool CanWrite => false;

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		throw new NotImplementedException("Can not write with this converter.");
	}

	public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		return new UnknownAtResult
		{
			Data = JObject.Load(reader)
		};
	}

	public override bool CanConvert(Type objectType) => objectType == typeof(IAtResult);
}
