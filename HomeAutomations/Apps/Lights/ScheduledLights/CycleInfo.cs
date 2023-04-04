using System.Linq;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Lights.ScheduledLights;

public class CycleInfo
{
	private int _currentIndex = -1;

	private readonly ILogger _logger;
	private readonly CycleConfig _config;
	private readonly IDisposable? _subscription;

	public CycleInfo(CycleConfig config, ILogger logger)
	{
		_config = config;
		_logger = logger;

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
				entity.CallService("turn_off");
			}
		}

		if (_currentIndex != -1)
		{
			foreach (var entity in _config.EntityCycles[_currentIndex])
			{
				_logger.Debug("Turning on {EntityId}", entity.EntityId);
				entity.CallService("turn_on");
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
				entity.CallService("turn_off");
			}
		}

		_subscription?.Dispose();
	}
}
