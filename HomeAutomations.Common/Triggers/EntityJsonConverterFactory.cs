using System.Text.Json;
using System.Text.Json.Serialization;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Common.Triggers;

public class EntityJsonConverterFactory(IServiceProvider serviceProvider) : JsonConverterFactory
{
	public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(Entity));

	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		var converterType = typeof(EntityJsonConverter<>).MakeGenericType(typeToConvert);

		return (JsonConverter?) Activator.CreateInstance(converterType, serviceProvider);
	}
}
