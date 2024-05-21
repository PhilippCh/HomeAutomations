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
	private readonly Dictionary<string, CycleInfo> _runningCycles = new();

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var cycle in Config.LightCycles)
		{
			var startTrigger = triggerRepository.GetTrigger(cycle.StartTriggerId);
			var endTrigger = triggerRepository.GetTrigger(cycle.EndTriggerId);

			if (startTrigger == null || endTrigger == null)
			{
				Logger.Warning(
					"Could not find start {StartTriggerId} or end {EndTriggerId} trigger for cycle {CycleName}",
					cycle.StartTriggerId, cycle.EndTriggerId, cycle.Name);

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
							_runningCycles.Add(cycle.Name, new CycleInfo(cycle, _entityStatePriorityManager, Logger));
						}
						else if (_runningCycles.TryGetValue(cycle.Name, out var runningCycle))
						{
							runningCycle.Stop();
							_runningCycles.Remove(cycle.Name);
						}
					});
		}

		return Task.CompletedTask;
	}
}
