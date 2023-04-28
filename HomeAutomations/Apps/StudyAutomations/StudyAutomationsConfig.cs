using System.Collections.Generic;
using HomeAutomations.Apps.StudyAutomations.Triggers;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations;

public record DeskLampConfig
{
	public LightEntity Entity { get; init; }
	public SensorEntity SwitchAction { get; init; }
	public TimeSpan Timeout { get; init; }
	public BrightnessTriggerConfig TriggerConfig { get; init; }
}

public record StudyAutomationsConfig : Config
{
	public SwitchEntity Speaker { get; init; }
	public IEnumerable<BinarySensorEntity> Computers { get; init; }
	public DeskLampConfig DeskLamp { get; init; }
}
