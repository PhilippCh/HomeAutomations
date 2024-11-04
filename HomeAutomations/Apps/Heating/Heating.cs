using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.Heating;

[Focus]
public class Heating(BaseAutomationDependencyAggregate<Heating, HeatingConfig> aggregate) : BaseAutomation<Heating, HeatingConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var thermostat in Config.Thermostats)
		{
			thermostat.WindowSensors
				.StateChangesWithCurrentState<BinarySensorEntity, BinarySensorAttributes>()
				.Throttle(Config.SensorDebounceTime)
				.Select(x => x.Select(y => y.New?.IsLikeOn() ?? false))
				.Subscribe(x => OnWindowSensorsChange(thermostat, x));
		}

		return Task.CompletedTask;
	}

	private void OnWindowSensorsChange(ThermostatConfig thermostat, IEnumerable<bool> states)
	{
		var isAnyWindowOpen = states.Any(x => x);
		Logger.Information("Window open state for {Thermostat} changed to {IsAnyWindowOpen}", thermostat.Name, isAnyWindowOpen);
		thermostat.WindowOpenSwitch.Switch(isAnyWindowOpen);
	}
}
