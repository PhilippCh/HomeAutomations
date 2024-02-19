using System.Collections.Generic;

namespace HomeAutomations.Entities.Converters.Sensors;

public class ChargingSensorEntityStateMap : ISensorEntityStateMap<bool?>
{
	public IReadOnlyDictionary<string, bool?> StateMap { get; } = new Dictionary<string, bool?>
	{
		{ "Charging", true },
		{ "Full", true },
		{ "Not Charging", false }
	};
}
