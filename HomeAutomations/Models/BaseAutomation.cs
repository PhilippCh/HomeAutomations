using System.Reactive.Disposables;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Attributes;
using HomeAutomations.Common.Models.Config;

namespace HomeAutomations.Models;

public class BaseAutomationDependencyAggregate<T, TConfig>(IHaContext context, IAppConfig<TConfig> config, ILogger loggerFactory)
	: BaseAutomationDependencyAggregate<T>(context, loggerFactory)
	where T : BaseAutomation<T, TConfig>
	where TConfig : Config, new()
{
	public IAppConfig<TConfig> Config { get; } = config;
}

public class BaseAutomationDependencyAggregate<T>(IHaContext context, ILogger loggerFactory)
	where T : BaseAutomation<T>
{
	public IHaContext Context { get; } = context;
	public ILogger Logger { get; } = loggerFactory.ForContext<T>();
}

public abstract class BaseAutomation<T, TConfig>(BaseAutomationDependencyAggregate<T, TConfig> aggregate)
	: BaseAutomation<T>(new BaseAutomationDependencyAggregate<T>(aggregate.Context, aggregate.Logger))
	where T : BaseAutomation<T, TConfig>
	where TConfig : Config, new()
{
	protected TConfig Config => aggregate.Config.Value;
}

[NetDaemonApp]
[HomeAutomation]
public abstract class BaseAutomation<T> : IAsyncInitializable, IDisposable where T : BaseAutomation<T>
{
	protected ILogger Logger { get; }
	protected IHaContext Context { get; }
	protected Generated.Services Services { get; }
	protected CompositeDisposable Disposables { get; } = new();

	private
		protected BaseAutomation(BaseAutomationDependencyAggregate<T> aggregate)
	{
		Context = aggregate.Context;
		Logger = aggregate.Logger;
		Services = new Generated.Services(Context);
	}

	public async Task InitializeAsync(CancellationToken cancellationToken) => await StartAsync(cancellationToken);

	protected abstract Task StartAsync(CancellationToken cancellationToken);

	public void Dispose()
	{
		Disposables.Dispose();
		GC.SuppressFinalize(this);
	}
}
