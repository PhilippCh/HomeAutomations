using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.ComputerSpeakers;

public class ComputerSpeakers : BaseAutomation<ComputerSpeakers, ComputerSpeakersConfig>
{
	public ComputerSpeakers(MqttService mqttService, BaseAutomationDependencyAggregate<ComputerSpeakers, ComputerSpeakersConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var speakerConfig in Config.Speakers)
		{
			speakerConfig.ComputerStateSensors.Select(e => e.StateChanges().Select(s => s.New.AsBoolean()).StartWith(e.EntityState.AsBoolean()))
				.CombineLatest()
				.Select(r => r.Any(s => s ?? false))
				.Subscribe(s => speakerConfig.Switch.SetState(s));
		}

		return Task.CompletedTask;
	}
}
