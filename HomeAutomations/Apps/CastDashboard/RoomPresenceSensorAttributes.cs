using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.CastDashboard;

[UsedImplicitly]
public record RoomPresenceSensorAttributes
{
	[JsonPropertyName("distance")]
	public double? Distance { get; init; }
};
