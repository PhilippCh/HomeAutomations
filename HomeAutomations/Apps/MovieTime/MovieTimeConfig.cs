using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MovieTime;

public record AvReceiverConfig
{
	public MediaPlayerEntity Entity { get; init; }
	public string DefaultSource { get; init; }
	public IEnumerable<LightEntity> DisableLights { get; init; }
}

public record MovieTimeConfig : Config
{
	public IEnumerable<LightEntity> Lights { get; init; }
	public RemoteEntity Remote { get; init; }
	public AvReceiverConfig AvReceiver { get; init; }
}
