using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Services;

public record EntityStateTarget
{
	public int Priority { get; init; }
	public bool TargetState { get; init; }
}

public class EntityStatePriorityManager(ILogger<EntityStatePriorityManager> _logger)
{
	private readonly Dictionary<string, Dictionary<string, EntityStateTarget>> _targetStates = new();

	public void AddTargetState(Entity entity, string tag, bool state, int priority)
	{
		var targetStates = GetTargetStates(entity);

		if (!targetStates.TryGetValue(tag, out var targetState))
		{
			targetState = new EntityStateTarget { Priority = priority, TargetState = state };
			targetStates.Add(tag, targetState);
		}

		targetStates[tag] = new EntityStateTarget
		{
			Priority = priority,
			TargetState = state
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
		if (_targetStates.TryGetValue(entity.EntityId, out var targetStates))
		{
			return targetStates;
		}

		targetStates = new Dictionary<string, EntityStateTarget>();
		_targetStates.Add(entity.EntityId, targetStates);

		return targetStates;
	}

	private void UpdateEntity(Entity entity)
	{
		var targetStates = GetTargetStates(entity).Values.OrderByDescending(x => x.Priority);
		var targetState = targetStates.FirstOrDefault();

		// TODO: Remove debugging statements.
		var logTargetStates = GetTargetStates(entity).Select(x => x).OrderByDescending(x => x.Value.Priority);
		_logger.LogInformation(string.Join("\n", logTargetStates.Select(x => $"{x.Value.Priority}: {x.Value.TargetState} ({x.Key})")));

		if (targetState == null)
		{
			_logger.LogWarning("Target state is null");

			return;
		}

		var service = targetState.TargetState ? "turn_on" : "turn_off";
		entity.CallService(service);
	}
}
