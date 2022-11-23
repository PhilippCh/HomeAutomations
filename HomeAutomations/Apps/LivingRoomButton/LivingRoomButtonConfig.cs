using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.LivingRoomButton;

public record LivingRoomButtonConfig : Config
{
	public SensorEntity Button { get; init; }
	public LightEntity StandardLamp { get; init; }
}
