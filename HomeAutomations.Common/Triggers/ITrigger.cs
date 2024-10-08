using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomeAutomations.Common.Triggers;

[JsonDerivedType(typeof(string))]
public interface ITrigger
{
	string? Id { get; init; }
	bool LatestValue { get; }

	IObservable<bool> AsObservable();

	/// <summary>
	/// This method is used to resolve references to other triggers in TriggerRepository. It should not be called by the user.
	/// </summary>
	/// <returns>All child triggers of this trigger</returns>
	IEnumerable<ITrigger> GetTriggersInternal();

	string GetDebugInfo() => JsonSerializer.Serialize(GetDebugInfoInternal(), new JsonSerializerOptions
	{
		WriteIndented = true
	});

	protected ExpandoObject GetDebugInfoInternal()
	{
		dynamic expando = new ExpandoObject();
		expando.Id = Id;
		expando.Type = GetType().Name;
		expando.Value = LatestValue;
		expando.Children = GetTriggersInternal().Select(x => x.GetDebugInfoInternal());

		return expando;
	}
}
