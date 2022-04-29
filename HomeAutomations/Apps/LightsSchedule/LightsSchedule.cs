using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.LightsSchedule;

public class LightsSchedule : BaseAutomation<LightsSchedule, LightsScheduleConfig>
{
	public LightsSchedule(BaseAutomationDependencyAggregate<LightsSchedule, LightsScheduleConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task Start(CancellationToken cancellationToken)
	{
		SetupLightCycles(cancellationToken);
		SetupFountainCycle(cancellationToken);

		return Task.CompletedTask;
	}

	private async void SetupLightCycles(CancellationToken cancellationToken)
	{
#pragma warning disable CS4014
		CronjobExtensions.ScheduleJob("0 9 * * *", StartLightCycles, false, cancellationToken).ConfigureAwait(false);
		CronjobExtensions.ScheduleJob("0 9 * * *", StartLightCycles, false, cancellationToken).ConfigureAwait(false);
#pragma warning restore CS4014
	}

	private async void StartLightCycles()
	{

	}

	private async void SetupFountainCycle(CancellationToken cancellationToken)
	{

		await CronjobExtensions.ScheduleJob(Config.UpdateCrontab, UpdateToken, true, cancellationToken);
	}

	private async void StartFountainCycle()
	{

	}
}
