using System.Text.Json;

namespace HomeAutomations.Tests.Extensions;

public static class ObjectExtensions
{
	public static JsonElement AsJsonElement(this object value)
	{
		var jsonString = JsonSerializer.Serialize(value);
		return JsonSerializer.Deserialize<JsonElement>(jsonString);
	}
}
