using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

public class AutomaticLights(BaseAutomationDependencyAggregate<AutomaticLights, AutomaticLightsConfig> aggregate, INotificationService notificationService)
	: BaseAutomation<AutomaticLights, AutomaticLightsConfig>(aggregate)
{
	private List<AutomaticLight> _lights = new();

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_lights = Config.Groups
			.SelectMany(g => g.Lights)
			.Select(e => new AutomaticLight(e, Logger, notificationService))
			.ToList();

		_lights.ForEach(l => l.StartMonitoring());

		return Task.CompletedTask;
	}
}
