namespace HomeAutomations.Converters.Sensors;

public class SensorEntityStateConverter<TStateMap, TOut> where TStateMap : ISensorEntityStateMap<TOut>, new()
{
	private readonly ISensorEntityStateMap<TOut> _stateMap = new TStateMap();

	public TOut? Convert(string? state)
	{
		if (state == null)
		{
			return default;
		}

		_stateMap.StateMap.TryGetValue(state, out var result);

		return result;
	}
}
