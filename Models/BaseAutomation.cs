using System;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Attributes;
using Microsoft.Extensions.Options;
using NetDaemon.AppModel;
using NetDaemon.HassModel;
using Serilog;

namespace HomeAutomations.Models;

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

[NetDaemonApp]
[HomeAutomation]
public abstract class BaseAutomation<T, TConfig> : IAsyncInitializable where T : BaseAutomation<T, TConfig> where TConfig : Config
{
	protected TConfig Config => _aggregate.Config.CurrentValue;
	protected ILogger Logger => _aggregate.Logger;
	protected IHaContext Context => _aggregate.Context;

	private readonly BaseAutomationDependencyAggregate<T, TConfig> _aggregate;

	protected BaseAutomation(BaseAutomationDependencyAggregate<T, TConfig> aggregate)
	{
		_aggregate = aggregate;
	}

	public async Task InitializeAsync(CancellationToken cancellationToken)
	{
		if (!Config.Enabled)
		{
			Logger.Warning("{class} is disabled.", GetType().Name);

			return;
		}

		await StartAsync(cancellationToken);
	}

	protected abstract Task StartAsync(CancellationToken cancellationToken);

	protected void ObserveConfigChange(Action<TConfig> action) => _aggregate.Config.OnChange(action);
}
