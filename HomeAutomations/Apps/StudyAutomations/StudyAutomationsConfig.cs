using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations;

public record DeskLampConfig
{
	public LightEntity Entity { get; init; }
	public SensorEntity SwitchAction { get; init; }
}

public record StudyAutomationsConfig : Config
{
	public string DeskLampTriggerId { get; init; }
	public string SpeakerTriggerid { get; init; }
	public SwitchEntity Speaker { get; init; }
	public DeskLampConfig DeskLamp { get; init; }
}
