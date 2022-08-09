using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class AtCommandParser
{
	private readonly IReadOnlyDictionary<Type, JSchema> _schemata;

	public AtCommandParser()
	{
		_schemata = CreateSchemata();
	}

	public IAtResult? Parse(JObject? message)
	{
		foreach (var schema in _schemata)
		{
			if (message?.IsValid(schema.Value) ?? false)
			{
				return (IAtResult?) message.ToObject(schema.Key);
			}
		}

		// Return a generic event object if all else fails.
		return message?.ToObject<EventAtResult>();
	}

	private IReadOnlyDictionary<Type, JSchema> CreateSchemata()
	{
		var generator = new JSchemaGenerator();
		var types = GetAtResultTypes();

		return types.Select(t => (Type: t, Schema: generator.Generate(t)))
			.ToDictionary(kv => kv.Type, kv => kv.Schema);
	}

	private IEnumerable<Type> GetAtResultTypes() => Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttribute<AtResultAttribute>() != null);
}
