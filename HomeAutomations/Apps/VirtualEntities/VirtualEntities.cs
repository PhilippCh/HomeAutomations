using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.VirtualEntities.Entities;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.VirtualEntities;

[Focus]
public class VirtualEntities(BaseAutomationDependencyAggregate<VirtualEntities, VirtualEntitiesConfig> aggregate, IMqttEntityManager entityManager)
	: BaseAutomation<VirtualEntities, VirtualEntitiesConfig>(aggregate)
{
	private SleepStateEntity? _sleepStateEntity;

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		_sleepStateEntity = new SleepStateEntity(Config.SleepStateEntity.EntityId, Config.SleepStateEntity, entityManager, Logger);
		await _sleepStateEntity.CreateAndObserveAsync();
	}
}
