using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.StudyAutomations.Triggers;
using HomeAutomations.Extensions;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.StudyAutomations;

[Focus]
public class StudyAutomations : BaseAutomation<StudyAutomations, StudyAutomationsConfig>
{

	public StudyAutomations(BaseAutomationDependencyAggregate<StudyAutomations, StudyAutomationsConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		new MultiBinarySwitchTrigger(Config.Computers).GetTrigger()
				.Subscribe(
					x =>
					{
						Logger.Information("Setting speakers to {State}", x);
						Config.Speaker.SetState(x);
					});

		new BrightnessTrigger(Config.DeskLampTriggerConfig).GetTrigger()
			.Subscribe(
				x =>
				{
					Logger.Information("Setting desk lamp to {State}", x);
					Config.DeskLamp.SetState(x);
				});

		return Task.CompletedTask;
	}
}
