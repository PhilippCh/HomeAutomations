﻿using System.Collections.Generic;
using System.Linq;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Extensions;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Entities.Extensions;

public static class EntityExtensions
{
	public static string GetName(this Entity entity) => entity.EntityId[(entity.EntityId.IndexOf('.') + 1)..];

	public static IObservable<StateChange<TEntity, EntityState<TAttributes>>> StateChangesWithCurrentState<TEntity, TAttributes>(this TEntity entity)
		where TEntity : Entity<TEntity, EntityState<TAttributes>, TAttributes>
		where TAttributes : class =>
		entity
			.StateAllChanges()
			.StartWith(new StateChange<TEntity, EntityState<TAttributes>>(entity, null, entity.EntityState));

	public static IObservable<IEnumerable<StateChange<TEntity, EntityState<TAttributes>>>> StateChangesWithCurrentState<TEntity, TAttributes>(this IEnumerable<TEntity> entities)
		where TEntity : Entity<TEntity, EntityState<TAttributes>, TAttributes>
		where TAttributes : class =>
		entities
			.Select(x => x.StateAllChanges().StartWith(new StateChange<TEntity, EntityState<TAttributes>>(x, null, x.EntityState)))
			.CombineLatest();

	public static IObservable<TAttributes> ValidAttributeChanges<TEntity, TAttributes>(this TEntity entity)
		where TEntity : Entity<TEntity, EntityState<TAttributes>, TAttributes>
		where TAttributes : class =>
		entity.StateAllChanges()
			.Where(x => x.New?.Attributes != null)
			.Select(x => x.New!.Attributes!);

	/// <summary>
	/// Returns whether the current entity state is *like* on (e.g. on, playing, etc.)
	/// </summary>
	/// <param name="state">Entity state</param>
	/// <returns>Is state like on</returns>
	public static bool IsLikeOn<TEntityState>(this TEntityState state) where TEntityState : EntityState =>
		state.IsOn() || string.Equals(state.State, EntityStates.Playing, StringComparison.OrdinalIgnoreCase);

	public static bool IsLikeOff<TEntityState>(this TEntityState state) where TEntityState : EntityState => state.IsOff() || state.IsUnavailable() || state.IsUnknown();

	public static bool IsUnavailable<TEntityState>(this TEntityState state) where TEntityState : EntityState =>
		string.Equals(state.State, EntityStates.Unavailable, StringComparison.OrdinalIgnoreCase);

	public static bool IsUnknown<TEntityState>(this TEntityState state) where TEntityState : EntityState =>
		string.Equals(state.State, EntityStates.Unknown, StringComparison.OrdinalIgnoreCase);

	public static bool Is<TEntity>(this Entity entity)
	{
		var type = typeof(TEntity);
		var domain = type.Name.TrimEnd("Entity");

		return entity.EntityId.StartsWith(domain, StringComparison.OrdinalIgnoreCase);
	}
}

public static class PersonEntityExtensions
{
	public static bool IsGpsPositionAccurate(this PersonAttributes attributes, double threshold) => (attributes.GpsAccuracy ?? double.MaxValue) < threshold;
}

public static class BinarySensorEntityExtensions
{
	public static IObservable<bool?> ToObservableState(this BinarySensorEntity entity) =>
		entity.StateChanges()
			.Select(x => x.New?.AsBoolean())
			.StartWith(entity.State.AsBoolean());
}

public static class InputBooleanExtensions
{
	public static void Switch(this InputBooleanEntity entity, bool isOn)
	{
		var action = (Action) (isOn ? entity.TurnOn : entity.TurnOff);
		action();
	}
}

public static class SwitchEntityExtensions
{
	public static void Switch(this SwitchEntity entity, bool isOn)
	{
		var action = (Action) (isOn ? entity.TurnOn : entity.TurnOff);
		action();
	}
}

public static class MediaPlayerEntityExtensions
{
	public static void Switch(this MediaPlayerEntity entity, bool isOn)
	{
		var action = (Action) (isOn ? entity.TurnOn : entity.TurnOff);
		action();
	}
}
