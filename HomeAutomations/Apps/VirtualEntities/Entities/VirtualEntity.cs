using System.Threading.Tasks;
using HomeAutomations.Constants;
using HomeAutomations.Extensions;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities.Entities;

public abstract class VirtualEntity<TOut, TConfig>
{
	protected string Id { get; set; }
	protected TConfig Config { get; private set; }

	private readonly IMqttEntityManager _entityManager;

	public VirtualEntity(TConfig config, IMqttEntityManager entityManager)
	{
		_entityManager = entityManager;
		Config = config;
	}

	public abstract IObservable<TOut> StateChanges();

	public abstract string StateToString(TOut state);

	public async Task CreateAndObserveAsync()
	{
		await _entityManager.CreateAsync(Id, new EntityCreationOptions(UniqueId: Id));
		StateChanges().SubscribeAsync(
			async x =>
			{
				await _entityManager.SetStateAsync(Id, StateToString(x));
			});
	}
}
