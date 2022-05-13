namespace HomeAutomations.Services;

public class BaseServiceDependencyAggregate<T> where T : BaseService<T>
{
	public ILogger Logger { get; }

	public BaseServiceDependencyAggregate(ILogger loggerFactory)
	{
		Logger = loggerFactory.ForContext<T>();
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
