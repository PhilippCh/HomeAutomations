using HomeAutomations.Common.Models.Config;
using Microsoft.Extensions.Options;
using Serilog;

namespace HomeAutomations.Common.Services;

public class BaseServiceDependencyAggregate<T, TConfig> : BaseServiceDependencyAggregate<T> where T : BaseService<T> where TConfig : Config
{
	public IOptionsMonitor<TConfig> Config { get; }

	public BaseServiceDependencyAggregate(IOptionsMonitor<TConfig> config)
	{
		Config = config;
	}
}

public class BaseServiceDependencyAggregate<T> where T : BaseService<T>
{
	public ILogger Logger { get; }

	public BaseServiceDependencyAggregate()
	{
		// ReSharper disable once ContextualLoggerProblem
		Logger = Log.Logger.ForContext<T>();
	}
}

public abstract class BaseService<T, TConfig> : BaseService<T> where T: BaseService<T> where TConfig : Config
{
	protected TConfig Config => _aggregate.Config.CurrentValue;

	private readonly BaseServiceDependencyAggregate<T, TConfig> _aggregate;

	public BaseService(BaseServiceDependencyAggregate<T, TConfig> aggregate)
		: base(new BaseServiceDependencyAggregate<T>())
	{
		_aggregate = aggregate;
	}
}

public abstract class BaseService<T> where T: BaseService<T>
{
	protected ILogger Logger => _aggregate.Logger;

	private readonly BaseServiceDependencyAggregate<T> _aggregate;

	public BaseService(BaseServiceDependencyAggregate<T> aggregate)
	{
		_aggregate = aggregate;
	}
}
