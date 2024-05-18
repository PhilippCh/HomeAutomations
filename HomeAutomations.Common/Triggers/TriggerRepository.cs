using System.Text.Json;
using Microsoft.Extensions.Options;

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

	public TriggerRepository(IOptions<TriggerRepositoryConfig> config, IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
		LoadTriggerConfigs(config.Value.Path);
	}

	private void LoadTriggerConfigs(string path)
	{
		var absolutePath = Path.Combine(AppContext.BaseDirectory, path);
		var triggerConfigs = Directory.EnumerateFiles(absolutePath, "*.trigger.json", SearchOption.AllDirectories);

		var serializerOptions = new JsonSerializerOptions
		{
			TypeInfoResolver = new TriggerTypeInfoResolver(),
			Converters = { new EntityJsonConverterFactory(_serviceProvider) }
		};
		var triggers = triggerConfigs.Select(File.ReadAllText)
			.Select(json => JsonSerializer.Deserialize<ITrigger>(json, serializerOptions))
			.ToList();
	}
}
