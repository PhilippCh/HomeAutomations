using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace HomeAutomations.Common.Triggers;

public class TriggerTypeInfoResolver : DefaultJsonTypeInfoResolver
{
	private readonly JsonPolymorphismOptions _polymorphismOptions;

	public TriggerTypeInfoResolver()
	{
		_polymorphismOptions = CreatePolymorphismOptions();
	}

	public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
	{
		var jsonTypeInfo = base.GetTypeInfo(type, options);

		if (jsonTypeInfo.Type == typeof(ITrigger))
		{
			jsonTypeInfo.PolymorphismOptions = _polymorphismOptions;
		}

		return jsonTypeInfo;
	}

	private JsonPolymorphismOptions CreatePolymorphismOptions()
	{
		var derivedTypes = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(x => x.GetTypes())
			.Where(
				x => typeof(ITrigger).IsAssignableFrom(x) &&
				     x is
				     {
					     IsInterface: false, IsAbstract: false
				     })
			.Select(x => new JsonDerivedType(x, x.Name))
			.ToList();

		var options = new JsonPolymorphismOptions
		{
			UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization
		};

		derivedTypes.ForEach(x => options.DerivedTypes.Add(x));

		return options;
	}
}
