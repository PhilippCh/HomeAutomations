using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public class ScheduledLights : BaseAutomation<ScheduledLights, ScheduledLightsConfig>
{
	private readonly Dictionary<string, CycleInfo> _runningCycles = new();

	public ScheduledLights(BaseAutomationDependencyAggregate<ScheduledLights, ScheduledLightsConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		ObservableExtensions.Interval(Config.UpdateInterval, true).Subscribe(_ => UpdateCycles());

		return Task.CompletedTask;
	}

	private void UpdateCycles()
	{
		foreach (var cycle in Config.LightCycles)
		{
			var start = cycle.Start.GetActualTime(Config.Latitude, Config.Longitude);
			var end = cycle.End.GetActualTime(Config.Latitude, Config.Longitude);

			if (start == null || end == null)
			{
				Logger.Warning("Could not get actual start/end dates for cycle {Cycle}. Start: {Start} End: {End}", cycle.Name, cycle.Start.ToString(), cycle.End.ToString());

				continue;
			}

			var time = DateTime.Now;
			var shouldRun = time >= start && time < end;

			// Start new cycle if within schedule.
			if (shouldRun && !_runningCycles.ContainsKey(cycle.Name))
			{
				_runningCycles.Add(cycle.Name, new CycleInfo(cycle, Logger));
			}

			// Stop running cycle if outside schedule.
			if (!shouldRun && _runningCycles.TryGetValue(cycle.Name, out var runningCycle))
			{
				runningCycle.Stop();
			}
		}
	}
}
