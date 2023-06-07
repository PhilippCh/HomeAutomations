using Newtonsoft.Json;

namespace HomeAutomations.Models;

public class StateChangedEvent
{
	[JsonProperty("entity_id")]
	public string EntityId { get; init; }
}
