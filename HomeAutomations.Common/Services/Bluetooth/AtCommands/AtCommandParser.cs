using System.Reflection;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Services.Bluetooth.AtCommands.Events;
using HomeAutomations.Common.Services.Bluetooth.AtCommands.Messages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class AtCommandParser
{
	private readonly IReadOnlyDictionary<Type, JSchema> _schemata;
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

	private IReadOnlyDictionary<Type, JSchema> CreateSchemata()
	{
		var generator = new JSchemaGenerator();
		var types = GetAtResultTypes();

		return types.Select(t => (Type: t, Schema: generator.Generate(t)))
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

		foreach (var schema in _schemata)
		{
			if (jsonMessage?.IsValid(schema.Value) ?? false)
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
