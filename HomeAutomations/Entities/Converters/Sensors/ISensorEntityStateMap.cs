using System.Collections.Generic;

namespace HomeAutomations.Entities.Converters.Sensors;

public interface ISensorEntityStateMap<TOut>
{
	IReadOnlyDictionary<string, TOut> StateMap { get; }
}
