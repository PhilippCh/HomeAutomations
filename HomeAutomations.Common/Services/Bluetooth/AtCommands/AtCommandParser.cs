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
			if (message?.IsValid(schema.Value, out IList<ValidationError> errors) ?? false)
			{
				return (IAtResult?) message.ToObject(schema.Key);
			}
		}

		return null;
	}

	private IReadOnlyDictionary<Type, JSchema> CreateSchemata()
	{
		var generator = new JSchemaGenerator();
		var types = new[] // TODO: Do this with attributes and reflection?
		{
			typeof(CommandAtResult)
		};

		return types.Select(t => (Type: t, Schema: generator.Generate(t)))
			.ToDictionary(kv => kv.Type, kv => kv.Schema);
	}
}
