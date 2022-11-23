using System.Reflection;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Parsers;
using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;
using NJsonSchema;

namespace HomeAutomations.Common.Services.Bluetooth.Commands;

public class AtCommandParser
{
	private readonly IReadOnlyDictionary<Type, JsonSchema> _schemata;
	private readonly IEnumerable<ICustomMessageParser> _customFormatters;

	public AtCommandParser()
	{
		_schemata = CreateSchemata();
		_customFormatters = CreatePreFormatters();
	}

	public IAtResult? Parse(string? message)
	{
		if (message == null)
		{
			return null;
		}

		return ParseWithSchemata(message) ??
		       ParseWithCustomParsers(message) ??
		       new UnknownAtResult
		       {
			       Data = JObjectExtensions.TryParse(message),
			       RawData = message
		       };
	}

	private IReadOnlyDictionary<Type, JsonSchema> CreateSchemata()
	{
		var types = GetAtResultTypes();

		return types.Select(t => (Type: t, Schema: JsonSchema.FromType(t)))
			.Select(
				kv =>
				{
					kv.Schema.AllowAdditionalProperties = true;

					return kv;
				})
			.ToDictionary(kv => kv.Type, kv => kv.Schema);
	}

	private IEnumerable<ICustomMessageParser> CreatePreFormatters()
	{
		return Assembly.GetExecutingAssembly()
			.GetTypes()
			.Where(t => typeof(ICustomMessageParser).IsAssignableFrom(t) && t.IsClass)
			.Select(Activator.CreateInstance)
			.Cast<ICustomMessageParser>();
	}

	private IEnumerable<Type> GetAtResultTypes() => Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttribute<AtResultAttribute>() != null);

	private IAtResult? ParseWithSchemata(string? message)
	{
		var jsonMessage = JObjectExtensions.TryParse(message);

		if (jsonMessage == null)
		{
			return null;
		}

		foreach (var schema in _schemata)
		{
			if (!schema.Value.Validate(jsonMessage).Any())
			{
				return (IAtResult?) jsonMessage.ToObject(schema.Key);
			}
		}

		return null;
	}

	private IAtResult? ParseWithCustomParsers(string? message)
	{
		var formatter = _customFormatters.FirstOrDefault(pf => pf.CanFormat(message));

		return formatter?.Format(message);
	}
}
