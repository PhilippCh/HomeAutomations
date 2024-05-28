using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

[Focus]
public class ScheduledLights(
	BaseAutomationDependencyAggregate<ScheduledLights, ScheduledLightsConfig> aggregate,
	EntityStatePriorityManager _entityStatePriorityManager,
	TriggerRepository triggerRepository) : BaseAutomation<ScheduledLights, ScheduledLightsConfig>(aggregate)
{
	private readonly Dictionary<string, CycleInfo> _activeCycles = new();

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var cycleConfig in Config.LightCycles)
		{
			var startTrigger = triggerRepository.GetTrigger(cycleConfig.StartTriggerId);
			var endTrigger = triggerRepository.GetTrigger(cycleConfig.EndTriggerId);

			if (startTrigger == null || endTrigger == null)
			{
				Logger.Warning(
					"Could not find start {StartTriggerId} or end {EndTriggerId} trigger for cycle {CycleName}",
					cycleConfig.StartTriggerId, cycleConfig.EndTriggerId, cycleConfig.Name);

				continue;
			}

			var endTriggerObservable = endTrigger.AsObservable().Select(y => !y).StartWith(true);

			startTrigger
				.AsObservable()
				.Where(x => x)
				.SwitchMap(_ => endTriggerObservable)
				.DistinctUntilChanged()
				.Subscribe(
					x =>
					{
						if (x)
						{
							StartLightCycle(cycleConfig);

							return;
						}

						// TODO: Implement proper logic with StartStopImmediate to ensure all lights are off when net-daemon restarts mid-cycle.
						if (_activeCycles.TryGetValue(cycleConfig.Name, out var activeCycle))
						{
							StopLightCycle(activeCycle);
						}
					});
		}

		return Task.CompletedTask;
	}

	private CycleInfo StartLightCycle(CycleConfig config, bool startUpdateImmediately = true)
	{
		var cycle = new CycleInfo(config, _entityStatePriorityManager, Logger, startUpdateImmediately);
		_activeCycles.Add(config.Name, cycle);

		return cycle;
	}

	private void StopLightCycle(CycleInfo cycle)
	{
		cycle.Stop();
		_activeCycles.Remove(cycle.Config.Name);
	}

	/// <summary>
	/// Stops an active light cycle. If there is no active light cycle found, we will start a new cycle, skip the lights update
	/// and stop the cycle immediately to ensure all lights are off if net-daemon has been unreachable for a longer period of time.
	/// </summary>
	private void StartStopLightCycleImmediately(CycleConfig config)
	{
		if (!_activeCycles.TryGetValue(config.Name, out var activeCycle))
		{
			activeCycle = StartLightCycle(config, false);
		}

		StopLightCycle(activeCycle);
	}
}
