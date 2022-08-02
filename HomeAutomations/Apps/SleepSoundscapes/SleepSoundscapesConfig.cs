using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.SleepSoundscapes;

public record SoundscapeConfig
{
	public string Id { get; init; }
	public string Directory { get; init; }
	public ButtonAction ButtonAction { get; init; }
}

public record SleepSoundscapesConfig : Config
{
	public string MpdServerHost { get; init; }
	public int CrossfadeSeconds { get; init; }
	public SensorEntity Sensor { get; init; }
	public IEnumerable<SoundscapeConfig> Soundscapes { get; init; }
}
