using System.Text.Json.Serialization;

namespace HomeAutomations.Common.Triggers;

[JsonDerivedType(typeof(string))]
public interface ITrigger
{
	string? Id { get; init; }

	IObservable<bool> AsObservable();

	/// <summary>
	/// This method is used to resolve references to other triggers in TriggerRepository. It should not be called by the user.
	/// </summary>
	/// <returns>All child triggers of this trigger</returns>
	IEnumerable<ITrigger> GetTriggersInternal();
}
