using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

[Focus]
public class ScheduledLights(
	BaseAutomationDependencyAggregate<ScheduledLights, ScheduledLightsConfig> aggregate,
	EntityStatePriorityManager _entityStatePriorityManager,
	IMqttEntityManager entityManager,
	TriggerRepository triggerRepository) : BaseAutomation<ScheduledLights, ScheduledLightsConfig>(aggregate)
{
	private readonly Dictionary<string, CycleInfo> _activeCycles = new();

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var cycleConfig in Config.LightCycles)
		{
			var creationOptions = new EntityCreationOptions(null, cycleConfig.StateEntity.EntityId, $"{cycleConfig.Name} light cycle state");
			await entityManager.CreateAsync(cycleConfig.StateEntity.EntityId, creationOptions);

			var startTrigger = triggerRepository.GetTrigger(cycleConfig.StartTriggerId);
			var endTrigger = triggerRepository.GetTrigger(cycleConfig.EndTriggerId);

			if (startTrigger == null || endTrigger == null)
			{
				Logger.Warning(
					"Could not find start {StartTriggerId} or end {EndTriggerId} trigger for cycle {CycleName}",
					cycleConfig.StartTriggerId, cycleConfig.EndTriggerId, cycleConfig.Name);

				continue;
			}

			// Restore last cycle state if automation fails/restarts for any reason.
			// This prevents <End> not being fired if net-daemon restarted during an active cycle because after a restart <Start> would have to be triggered first.
			var initialState = cycleConfig.StateEntity.EntityState?.IsOffOrUnavailable() ?? true ? ActiveTriggerState.Start : ActiveTriggerState.End;
			startTrigger
				.WithEnd(endTrigger, initialState)
				.SubscribeAsync(
					async x =>
					{
						if (x)
						{
							await StartLightCycle(cycleConfig);

							return;
						}

						// TODO: Implement proper logic with StartStopImmediate to ensure all lights are off when net-daemon restarts mid-cycle.
						if (_activeCycles.TryGetValue(cycleConfig.Name, out var activeCycle))
						{
							await StopLightCycle(activeCycle);
						}
					});
		}
	}

	private async Task<CycleInfo> StartLightCycle(CycleConfig config, bool startUpdateImmediately = true)
	{
		var cycle = new CycleInfo(config, _entityStatePriorityManager, Logger, startUpdateImmediately);
		_activeCycles.Add(config.Name, cycle);

		await entityManager.SetStateAsync(config.StateEntity.EntityId, EntityStates.On);

		return cycle;
	}

	private async Task StopLightCycle(CycleInfo cycle)
	{
		cycle.Stop();
		_activeCycles.Remove(cycle.Config.Name);

		await entityManager.SetStateAsync(cycle.Config.StateEntity.EntityId, EntityStates.Off);
	}

	/// <summary>
	/// Stops an active light cycle. If there is no active light cycle found, we will start a new cycle, skip the lights update
	/// and stop the cycle immediately to ensure all lights are off if net-daemon has been unreachable for a longer period of time.
	/// </summary>
	private async Task StartStopLightCycleImmediately(CycleConfig config)
	{
		if (!_activeCycles.TryGetValue(config.Name, out var activeCycle))
		{
			activeCycle = await StartLightCycle(config, false);
		}

		StopLightCycle(activeCycle);
	}
}
