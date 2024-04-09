using HomeAutomations.Apps.VirtualEntities.Entities;
using HomeAutomations.Common.Models.Config;

namespace HomeAutomations.Apps.VirtualEntities;

public abstract record VirtualEntityConfig
{
	public string EntityId { get; init; }
}

public record VirtualEntitiesConfig : Config
{
	public SleepStateEntityConfig SleepStateEntity { get; init; }
}
