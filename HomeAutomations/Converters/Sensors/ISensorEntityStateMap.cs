using System.Collections.Generic;

namespace HomeAutomations.Converters.Sensors;

public interface ISensorEntityStateMap<TOut>
{
	IReadOnlyDictionary<string, TOut> StateMap { get; }
}
