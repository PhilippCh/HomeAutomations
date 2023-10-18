﻿using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Attributes;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Models;

public class BaseAutomationDependencyAggregate<T, TConfig> : BaseAutomationDependencyAggregate<T>
	where T : BaseAutomation<T, TConfig>
	where TConfig : Config, new()
{
	public IAppConfig<TConfig> Config { get; }

	public BaseAutomationDependencyAggregate(IHaContext context, IAppConfig<TConfig> config, ILogger loggerFactory)
		: base(context, loggerFactory)
	{
		Config = config;
	}
}

public class BaseAutomationDependencyAggregate<T> where T : BaseAutomation<T>
{
	public IHaContext Context { get; }
	public ILogger Logger { get; }
	public Entities Entities => new(Context);

	public BaseAutomationDependencyAggregate(IHaContext context, ILogger loggerFactory)
	{
		Context = context;
		// ReSharper disable once ContextualLoggerProblem
		Logger = loggerFactory.ForContext<T>();
	}
}

public abstract class BaseAutomation<T, TConfig> : BaseAutomation<T> where T : BaseAutomation<T, TConfig> where TConfig : Config, new()
{
	protected TConfig Config => _aggregate.Config.Value;
	protected Entities Entities => _aggregate.Entities;

	private readonly BaseAutomationDependencyAggregate<T, TConfig> _aggregate;

	protected BaseAutomation(BaseAutomationDependencyAggregate<T, TConfig> aggregate)
		: base(new BaseAutomationDependencyAggregate<T>(aggregate.Context, aggregate.Logger))
	{
		_aggregate = aggregate;
	}
}

[NetDaemonApp]
[HomeAutomation]
public abstract class BaseAutomation<T> : IAsyncInitializable where T : BaseAutomation<T>
{
	protected ILogger Logger { get; }
	protected IHaContext Context { get; }
	protected Generated.Services Services { get; }

	private
		protected BaseAutomation(BaseAutomationDependencyAggregate<T> aggregate)
	{
		Context = aggregate.Context;
		Services = new Generated.Services(aggregate.Context);
		Logger = aggregate.Logger;
	}

	public async Task InitializeAsync(CancellationToken cancellationToken) => await StartAsync(cancellationToken);

	protected abstract Task StartAsync(CancellationToken cancellationToken);
}
