using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.MovieTime;

public record ToggleEntitiesByMediaSourceConfig {
public IEnumerable<string> MediaSources { get; init; }
public IEnumerable<Entity> Entities { get; init; }
}

public record AvReceiverConfig
{
	public MediaPlayerEntity Entity { get; init; }
	public string DefaultSource { get; init; }
	public IEnumerable<ToggleEntitiesByMediaSourceConfig> ToggleEntities { get; init; }
	public SwitchEntity Subwoofer { get; init; }
}

public record MovieTimeConfig : Config
{
	public IEnumerable<LightEntity> Lights { get; init; }
	public RemoteEntity Remote { get; init; }
	public AvReceiverConfig AvReceiver { get; init; }
}
