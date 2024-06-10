using System.Text.Json.Serialization;

namespace HomeAutomations.Triggers.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CompareOperator
{
	GreaterThan,
	LowerThan
}
