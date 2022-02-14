using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using HomeAssistant.Automations.Apps.Cast;
using HomeAssistant.Automations.Models;
using HomeAssistantGenerated;
using NetDaemon.Common;
using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Apps.CastDashboard;

[NetDaemonApp]
[Focus]
public class CastDashboard : BaseAutomation<CastDashboard, CastDashboardConfig>
{
	private double _currentMinDistance;

	private readonly CastServices _castService;
	private readonly IEnumerable<Entity<RoomPresenceSensorAttributes>> _presenceSensors;

	public CastDashboard(BaseAutomationDependencyAggregate<CastDashboard, CastDashboardConfig> aggregate)
		: base(aggregate)
	{
		_castService = new HomeAssistantGenerated.Services(Context).Cast;
		_presenceSensors = Config.PresenceSensors.Select(ps => new Entity<RoomPresenceSensorAttributes>(Context, ps));
	}

	protected override void Start()
	{
		_presenceSensors.StateAllChanges()
			.Where(s => s.New?.Attributes?.Distance.HasValue ?? false)
			.Select(s => s.New!.Attributes!.Distance)
			.Subscribe(d => UpdateMinCastDistance(d!.Value));
	}

	private void UpdateMinCastDistance(double distance)
	{
		_currentMinDistance = Math.Min(_currentMinDistance, distance);

		if (_currentMinDistance < Config.MinCastDistance)
		{
			_castService.ShowLovelaceView(Config.Target, Config.DashboardPath, Config.ViewPath);
		}
	}
}
