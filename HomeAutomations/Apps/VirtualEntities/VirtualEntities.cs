using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.VirtualEntities.Entities;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities;

[Focus]
public class VirtualEntities : BaseAutomation<VirtualEntities, VirtualEntitiesConfig>
{
	private readonly IMqttEntityManager _entityManager;
	private readonly IHaContext _context;

	private SleepStateEntity _sleepStateEntity;

	public VirtualEntities(BaseAutomationDependencyAggregate<VirtualEntities, VirtualEntitiesConfig> aggregate, IMqttEntityManager entityManager, IHaContext context)
		: base(aggregate)
	{
		_entityManager = entityManager;
		_context = context;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_sleepStateEntity = new SleepStateEntity("binary_sensor.presence_bedroom_is_anyone_sleeping", Config.SleepStateEntity, _entityManager);
		await _sleepStateEntity.CreateAndObserveAsync();
	}
}
