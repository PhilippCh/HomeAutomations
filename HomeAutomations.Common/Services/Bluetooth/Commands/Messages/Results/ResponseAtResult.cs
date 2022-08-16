using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

[AtResult]
[JsonConverter(typeof(ResponseAtResultJsonConverter))]
public class ResponseAtResult : IAtResult
{
	[JsonProperty("R", Required = Required.Always)]
	public int Id { get; set; }

	[JsonIgnore]
	public JObject Data { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
		atCommandService.OnResponseResultReceived(this);
	}
}

public class ResponseAtResultJsonConverter : JsonConverter
{
	public override bool CanRead => true;

	public override bool CanWrite => false;

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		throw new NotImplementedException("Can not write with this converter.");
	}

	public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		var responseResult = new ResponseAtResult();
		var jObject = JObject.Load(reader);

		var id = jObject["R"]?.Value<int>();

		if (id == null)
		{
			throw new InvalidCastException("No command id present on response object.");
		}

		responseResult.Id = id.Value;
		jObject.Remove("R");

		var dataJson = jObject.ToString(Formatting.None);
		responseResult.Data = JObject.Parse(dataJson);

		return responseResult;
	}

	public override bool CanConvert(Type objectType) => objectType == typeof(ResponseAtResult);
}
