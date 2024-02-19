using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Entities.Extensions;

public static class EntityExtensions
{
	public static string GetName(this Entity entity) => entity.EntityId[(entity.EntityId.IndexOf('.') + 1)..];

	public static IObservable<StateChange<TEntity, EntityState<TAttributes>>> StateChangesWithCurrentState<TEntity, TAttributes>(this TEntity entity)
		where TEntity : Entity<TEntity, EntityState<TAttributes>, TAttributes>
		where TAttributes : class
	{
		return entity.StateChanges().StartWith(new StateChange<TEntity, EntityState<TAttributes>>(entity, null, null));
	}
}

public static class PersonEntityExtensions
{
	public static bool IsGpsPositionAccurate(this PersonAttributes attributes, double threshold)
	{
		var accuracy = attributes.GpsAccuracy ?? double.MaxValue;

		return accuracy < threshold;
	}
}

public static class BinarySensorEntityExtensions
{
	public static IObservable<bool?> ToObservableState(this BinarySensorEntity entity) =>
		entity.StateChanges()
			.Select(x => x.New?.AsBoolean())
			.StartWith(entity.State.AsBoolean());
}
