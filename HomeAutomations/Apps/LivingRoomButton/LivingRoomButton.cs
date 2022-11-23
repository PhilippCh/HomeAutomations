using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LivingRoomButton;

public class LivingRoomButton : BaseAutomation<LivingRoomButton, LivingRoomButtonConfig>
{
	public LivingRoomButton(BaseAutomationDependencyAggregate<LivingRoomButton, LivingRoomButtonConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Config.Button.StateChanges().Subscribe(s => OnButtonPressed(s.New?.State));

		return Task.CompletedTask;
	}

	private void OnButtonPressed(string? state)
	{
		var action = WirelessSwitchActions.Map(state);

		if (action == ButtonAction.Single)
		{
			Config.StandardLamp.Toggle();
		}
	}
}
