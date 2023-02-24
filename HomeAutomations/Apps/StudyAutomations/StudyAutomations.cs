using System.Linq;
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

		Observable.CombineLatest(
			new BrightnessTrigger(Config.DeskLampTriggerConfig).GetTrigger(),
			new MultiBinarySwitchTrigger(Config.Computers).GetTrigger())
			.Subscribe(
				x =>
				{
					var state = x.All(y => y);
					Logger.Information("Setting desk lamp to {State}", state);
					Config.DeskLamp.SetState(state);
				});

		return Task.CompletedTask;
	}
}
