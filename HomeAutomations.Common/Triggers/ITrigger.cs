using System.Text.Json.Serialization;

namespace HomeAutomations.Common.Triggers;

[JsonDerivedType(typeof(string))]
public interface ITrigger
{
	IObservable<bool> AsObservable();
}
