using System;
using Microsoft.Extensions.Options;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using Serilog;

namespace HomeAssistant.Automations.Models;

public class BaseAutomationDependencyAggregate<T, TConfig> where T : BaseAutomation<T, TConfig> where TConfig : Config
{
	public IHaContext Context { get; }
	public IOptionsMonitor<TConfig> Config { get; }
	public ILogger Logger { get; }

	public BaseAutomationDependencyAggregate(IHaContext context, IOptionsMonitor<TConfig> config, ILogger loggerFactory)
	{
		Context = context;
		Config = config;
		Logger = loggerFactory.ForContext<T>();
	}
}

public abstract class BaseAutomation<T, TConfig> : IInitializable where T : BaseAutomation<T, TConfig> where TConfig : Config
{
	protected TConfig Config => _aggregate.Config.CurrentValue;
	protected ILogger Logger => _aggregate.Logger;
	protected IHaContext Context => _aggregate.Context;

	private readonly BaseAutomationDependencyAggregate<T, TConfig> _aggregate;

	public BaseAutomation(BaseAutomationDependencyAggregate<T, TConfig> aggregate)
	{
		_aggregate = aggregate;
	}

	public void Initialize()
	{
		if (!Config.Enabled)
		{
			Logger.Warning("{class} is disabled.", GetType().Name);

			return;
		}

		Start();
	}

	protected abstract void Start();

	protected void ObserveConfigChange(Action<TConfig> action) => _aggregate.Config.OnChange(action);
}
