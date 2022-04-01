namespace HomeAutomations.Common.Models.Config;

public record StagedConfig<T>
{
	public IReadOnlyDictionary<string, T> Values { get; init; }

	public T? CurrentValue
	{
		get
		{
			var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

			return Values.TryGetValue(environment, out var value) ? value : default;
		}
	}
}

public abstract record Config
{
	public bool Debug { get; init; }
}
