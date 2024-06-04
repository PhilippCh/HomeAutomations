using System.Collections.Generic;
using System.Linq;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Services;

public record EntityStateTarget
{
	public int Priority { get; init; }
	public Action<Entity> TargetState { get; init; }
}

public class EntityStatePriorityManager
{
	private readonly Dictionary<string, Dictionary<string, EntityStateTarget>> _targetStateSetters = new();

	public void AddTargetState<T>(T entity, string tag, Action<T> stateSetter, int priority) where T : Entity
	{
		var targetStates = GetTargetStates(entity);

		if (!targetStates.TryGetValue(tag, out var targetState))
		{
			targetState = new EntityStateTarget { Priority = priority, TargetState = (Action<Entity>) stateSetter };
			targetStates.Add(tag, targetState);
		}

		targetStates[tag] = new EntityStateTarget
		{
			Priority = priority,
			TargetState = (Action<Entity>) stateSetter
		};

		UpdateEntity(entity);
	}

	public void RemoveTargetStateForTag(Entity entity, string tag)
	{
		var targetStates = GetTargetStates(entity);
		targetStates.Remove(tag);

		UpdateEntity(entity);
	}

	private Dictionary<string, EntityStateTarget> GetTargetStates(Entity entity)
	{
		if (_targetStateSetters.TryGetValue(entity.EntityId, out var targetStates))
		{
			return targetStates;
		}

		targetStates = new Dictionary<string, EntityStateTarget>();
		_targetStateSetters.Add(entity.EntityId, targetStates);

		return targetStates;
	}

	private void UpdateEntity(Entity entity)
	{
		var targetStates = GetTargetStates(entity).Values.OrderByDescending(x => x.Priority);
		var targetState = targetStates.FirstOrDefault();

		targetState?.TargetState(entity);
	}
}
