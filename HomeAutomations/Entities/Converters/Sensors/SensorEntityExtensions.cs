using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Entities.Converters.Sensors;

public static class SensorEntityExtensions
{
	public static IObservable<TOut?> ToObservableState<T, TOut>(this SensorEntity entity) where T : ISensorEntityStateMap<TOut>, new()
	{
		var stateConverter = new SensorEntityStateConverter<T, TOut>();

		return entity.StateChanges()
			.Select(x => stateConverter.Convert(x.New?.State))
			.StartWith(stateConverter.Convert(entity.State));
	}
}
