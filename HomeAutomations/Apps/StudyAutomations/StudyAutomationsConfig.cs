using System.Collections.Generic;
using HomeAutomations.Apps.StudyAutomations.Triggers;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.StudyAutomations;

public record StudyAutomationsConfig : Config
{
	public SwitchEntity Speaker { get; init; }
	public IEnumerable<BinarySensorEntity> Computers { get; init; }
	public LightEntity DeskLamp { get; init; }
	public BrightnessTriggerConfig DeskLampTriggerConfig { get; init; }
}
