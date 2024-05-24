using System.Text.Json;
using Microsoft.Extensions.Options;
using ILogger = Serilog.ILogger;

namespace HomeAutomations.Common.Triggers;

public record TriggerRepositoryConfig
{
	public string Path { get; init; } = string.Empty;
}

// This class needs to be scoped to a NetDaemonApp, because creating entity classes from within the
// EntityJsonConverter requires a service instance of AppScopedHaContextProvider, which is only
// available in the scope of a NetDaemonApp.
public class TriggerRepository
{
	private readonly IServiceProvider _serviceProvider;
	private readonly IReadOnlyDictionary<string, ITrigger> _cachedTriggers;

	public TriggerRepository(IOptions<TriggerRepositoryConfig> config, IServiceProvider serviceProvider, ILogger loggerFactory)
	{
		_serviceProvider = serviceProvider;
		var logger = loggerFactory.ForContext<TriggerRepository>();

		var triggerConfigs = LoadTriggerConfigs(config.Value.Path).ToList();
		var missingIdTriggerConfigs = triggerConfigs
			.Where(x => x.Trigger.Id == null)
			.ToList();

		if (missingIdTriggerConfigs.Count > 0)
		{
			logger.Warning("Found trigger config files with missing id: {MissingIds}", missingIdTriggerConfigs.Select(x => x.Path));
		}

		_cachedTriggers = triggerConfigs.ToDictionary(x => x.Trigger.Id!, x => x.Trigger);
	}

	public virtual ITrigger? GetTrigger(string name) => _cachedTriggers.GetValueOrDefault(name);

	private IEnumerable<(string Path, ITrigger Trigger)> LoadTriggerConfigs(string path)
	{
		var absolutePath = Path.Combine(AppContext.BaseDirectory, path);
		var triggerConfigs = Directory.EnumerateFiles(absolutePath, "*.trigger.json", SearchOption.AllDirectories);

		var serializerOptions = new JsonSerializerOptions
		{
			TypeInfoResolver = new TriggerTypeInfoResolver(),
			Converters = { new EntityJsonConverterFactory(_serviceProvider) }
		};

		var triggers = triggerConfigs.Select(x => (Path: x, Json: File.ReadAllText(x)))
			.Select(x => (x.Path, Trigger: JsonSerializer.Deserialize<ITrigger>(x.Json, serializerOptions)))
			.Where(x => x.Trigger != null)
			.Select(x => (x.Path, Trigger: x.Trigger!))
			.ToList();

		ResolveTriggerRefs(triggers.Select(x => x.Trigger).ToList());

		return triggers;
	}

	private void ResolveTriggerRefs(IList<ITrigger> triggers)
	{
		foreach (var trigger in triggers)
		{
			if (trigger is TriggerRefTrigger triggerRef)
			{
				triggerRef.ResolveRef(triggers);
			}

			ResolveTriggerRefs(trigger.GetTriggersInternal().ToList());
		}
	}
}
