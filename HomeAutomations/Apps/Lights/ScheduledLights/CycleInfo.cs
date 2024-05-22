using System.Linq;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public class CycleInfo
{
	public CycleConfig Config { get; }

	private int _currentIndex = -1;

	private readonly ILogger _logger;
	private readonly EntityStatePriorityManager _entityStatePriorityManager;
	private readonly IDisposable? _subscription;

	public CycleInfo(CycleConfig config, EntityStatePriorityManager entityStatePriorityManager, ILogger logger, bool startUpdateImmediately = true)
	{
		Config = config;
		_logger = logger;
		_entityStatePriorityManager = entityStatePriorityManager;

		logger.Information("Starting light cycle {Name}", config.Name);

		if (startUpdateImmediately)
		{
			Update();
		}

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
			foreach (var entity in Config.EntityCycles[previousIndex])
			{
				_logger.Debug("Turning off {EntityId}", entity.EntityId);
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), x => x.CallService("turn_off"), 0);
			}
		}

		if (_currentIndex != -1)
		{
			foreach (var entity in Config.EntityCycles[_currentIndex])
			{
				_logger.Debug("Turning on {EntityId}", entity.EntityId);
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), x =>
				{
					x.CallService("turn_on", new LightTurnOnParameters
					{
						BrightnessPct = 100
					});
				}, 0);
			}
		}
	}

	private int RotateIndex()
	{
		if (_currentIndex >= Config.EntityCycles.Count - 1)
		{
			// There is a special case where there's only a single group.
			// If we don't return -1, we would turn the entity off, then immediately turn it back on again.
			return Config.EntityCycles.Count == 1 ? -1 : 0;
		}

		return _currentIndex + 1;
	}

	public void Stop()
	{
		_logger.Information("Stopping light cycle {Name}", Config.Name);

		// Turn off all lights when cycle has finished.
		foreach (var group in Config.EntityCycles.Select(c => c))
		{
			foreach (var entity in group)
			{
				_entityStatePriorityManager.AddTargetState(entity, nameof(CycleInfo), x => x.CallService("turn_off"), 0);
			}
		}

		_subscription?.Dispose();
	}
}
