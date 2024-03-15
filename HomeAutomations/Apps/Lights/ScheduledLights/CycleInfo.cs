using System.Linq;
using HomeAutomations.Services;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public class CycleInfo
{
	private int _currentIndex = -1;

	private readonly ILogger _logger;
	private readonly EntityStatePriorityManager _entityStatePriorityManager;
	private readonly CycleConfig _config;
	private readonly IDisposable? _subscription;

	public CycleInfo(CycleConfig config, EntityStatePriorityManager entityStatePriorityManager, ILogger logger)
	{
		_config = config;
		_logger = logger;
		_entityStatePriorityManager = entityStatePriorityManager;

		logger.Information("Starting light cycle {Name}", config.Name);

		Update();

		if (config.Interval != null)
		{
			_subscription = ObservableExtensions.Interval(config.Interval.Value).Subscribe(_ => Update());
		}
	}

	private void Update()
	{
		var previousIndex = _currentIndex;
		_currentIndex = RotateIndex();

		_logger.Debug("Current light rotation index: {Index}", _currentIndex);

		if (previousIndex != -1)
		{
			foreach (var entity in _config.EntityCycles[previousIndex])
			{
				_logger.Debug("Turning off {EntityId}", entity.EntityId);
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), false, 0);
			}
		}

		if (_currentIndex != -1)
		{
			foreach (var entity in _config.EntityCycles[_currentIndex])
			{
				_logger.Debug("Turning on {EntityId}", entity.EntityId);
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), true, 0);
			}
		}
	}

	private int RotateIndex()
	{
		if (_currentIndex >= _config.EntityCycles.Count - 1)
		{
			// There is a special case where there's only a single group.
			// If we don't return -1, we would turn the entity off, then immediately turn it back on again.
			return _config.EntityCycles.Count == 1 ? -1 : 0;
		}

		return _currentIndex + 1;
	}

	public void Stop()
	{
		_logger.Information("Stopping light cycle {Name}", _config.Name);

		// Turn off all lights when cycle has finished.
		foreach (var group in _config.EntityCycles.Select(c => c))
		{
			foreach (var entity in group)
			{
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), false, 0);
			}
		}

		_subscription?.Dispose();
	}
}
