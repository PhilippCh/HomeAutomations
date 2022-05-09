using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.LightsSchedule;

[Focus]
public class LightsSchedule : BaseAutomation<LightsSchedule, LightsScheduleConfig>
{
	private readonly Dictionary<string, CycleInfo> _runningCycles = new();

	public LightsSchedule(BaseAutomationDependencyAggregate<LightsSchedule, LightsScheduleConfig> aggregate)
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
			var shouldRun = time >= start || time < end;

			if (shouldRun && !_runningCycles.ContainsKey(cycle.Name))
			{
				_runningCycles.Add(cycle.Name, new CycleInfo(cycle));
			}
		}
	}
}
