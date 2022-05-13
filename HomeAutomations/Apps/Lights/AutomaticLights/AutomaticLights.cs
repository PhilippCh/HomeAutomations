using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.Lights.AutomaticLights;

public class AutomaticLights : BaseAutomation<AutomaticLights, AutomaticLightsConfig>
{
	public AutomaticLights(BaseAutomationDependencyAggregate<AutomaticLights, AutomaticLightsConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var group in Config.Groups)
		{
			foreach (var lightTrigger in group.Lights)
			{
				lightTrigger.ManualTriggerSensor.StateChanges().Subscribe(s => OnManualTriggerStateChanged(lightTrigger, s.New?.State));
			}
		}

		return Task.CompletedTask;
	}

	private void OnManualTriggerStateChanged(AutomaticLightEntity lightTrigger, string? state)
	{
		var buttonAction = WirelessSwitchActions.Map(state);

		Action action = buttonAction switch
		{
			_ => () => lightTrigger.Entity.Toggle()
		};

		action();
	}
}
