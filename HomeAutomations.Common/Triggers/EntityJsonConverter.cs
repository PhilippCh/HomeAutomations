using System.Text.Json;
using System.Text.Json.Serialization;
using HomeAutomations.Models.Generated;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.HassModel.Entities;

public class EntityJsonConverter<T>(IServiceProvider serviceProvider) : JsonConverter<T>
	where T : Entity
{
	public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.String)
		{
			throw new JsonException("Expected an entity id string.");
		}

		var entityId = reader.GetString();
		var entity = ActivatorUtilities.CreateInstance(serviceProvider, typeToConvert, entityId) as T;

		return entity;
	}

	public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.EntityId);
	}
}
