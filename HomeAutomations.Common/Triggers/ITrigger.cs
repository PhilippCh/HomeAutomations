using System.Text.Json.Serialization;

namespace HomeAutomations.Common.Triggers;

[JsonDerivedType(typeof(string))]
public interface ITrigger
{
	string? Id { get; init; }

	IObservable<bool> AsObservable();
}
