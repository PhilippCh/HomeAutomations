using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MovieTime;

public record MovieTimeConfig : Config
{
	public IEnumerable<LightEntity> Lights { get; init; }
	public RemoteEntity Remote { get; init; }
}
