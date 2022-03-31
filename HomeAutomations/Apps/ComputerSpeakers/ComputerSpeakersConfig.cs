using System.Collections.Generic;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.ComputerSpeakers;

public record ComputerSpeakerConfig : Config
{
	public SwitchEntity Switch { get; init; }
	public IEnumerable<BinarySensorEntity> ComputerStateSensors { get; init; }
}

public record ComputerSpeakersConfig : Config
{
	public IEnumerable<ComputerSpeakerConfig> Speakers { get; init; }
}
