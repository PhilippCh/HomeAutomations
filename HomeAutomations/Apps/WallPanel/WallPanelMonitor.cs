using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Apps.WallPanel;

[Focus]
public class WallPanelMonitor : BaseAutomation<WallPanelMonitor, WallPanelMonitorConfig>
{
	private readonly IEnumerable<WallPanel> _panels;

	[UsedImplicitly]
	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.AddScoped<WallPanel.WallPanelFactory>()
			.AddScoped<WallPanel>();

	public WallPanelMonitor(WallPanel.WallPanelFactory wallPanelFactory, BaseAutomationDependencyAggregate<WallPanelMonitor, WallPanelMonitorConfig> aggregate)
		: base(aggregate)
	{
		_panels = Config?.Panels?.Select(p => wallPanelFactory.Create(Config, p)) ?? Enumerable.Empty<WallPanel>();
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var panel in _panels)
		{
			await panel.StartMonitoringAsync();
		}
	}
}
