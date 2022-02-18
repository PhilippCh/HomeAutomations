using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Automations.Apps.Scales.KitchenScale;
using HomeAutomations.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Apps.WallPanel;

public class WallPanelMonitor : BaseAutomation<WallPanelMonitor, WallPanelMonitorConfig>
{
	private readonly IEnumerable<WallPanel> _panels;

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddScoped<WallPanel.WallPanelFactory>()
			.AddScoped<WallPanel>();

	public WallPanelMonitor(WallPanel.WallPanelFactory wallPanelFactory, BaseAutomationDependencyAggregate<WallPanelMonitor, WallPanelMonitorConfig> aggregate) : base(aggregate)
	{
		_panels = Config?.Panels?.Select(wallPanelFactory.Create) ?? Enumerable.Empty<WallPanel>();
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var panel in _panels)
		{
			panel.StartMonitoring();
		}

		return Task.CompletedTask;
	}
}
