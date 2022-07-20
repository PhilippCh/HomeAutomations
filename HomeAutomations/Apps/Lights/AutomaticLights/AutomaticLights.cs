using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

[Focus]
public class AutomaticLights : BaseAutomation<AutomaticLights, AutomaticLightsConfig>
{
	private readonly NotificationService _notificationService;
	private List<AutomaticLight> _lights = new();

	public AutomaticLights(BaseAutomationDependencyAggregate<AutomaticLights, AutomaticLightsConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		_lights = Config.Groups
			.SelectMany(g => g.Lights)
			.Select(e => new AutomaticLight(e, Logger, _notificationService))
			.ToList();

		_lights.ForEach(l => l.StartMonitoring());

		return Task.CompletedTask;
	}
}
