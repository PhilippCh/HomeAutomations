using System.Linq;
using HomeAutomations.Models.Generated;
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

		if (previousIndex != -1)
		{
			foreach (var entity in _config.EntityCycles[previousIndex])
			{
				_logger.Debug("Turning off {EntityId}", entity.EntityId);
				entity.TurnOff();
			}
		}

		if (_currentIndex != -1)
		{
			foreach (var entity in _config.EntityCycles[_currentIndex])
			{
				_logger.Debug("Turning on {EntityId}", entity.EntityId);
				entity.TurnOn();
			}
		}
	}

	private int RotateIndex()
	{
		if (_currentIndex >= _config.EntityCycles.Count - 1)
		{
			return -1;
		}

		return _currentIndex + 1;
	}

	public void Stop()
	{
		_logger.Information("Stopping light cycle {Name}", _config.Name);

		// Turn off all lights when cycle has finished.
		foreach (var entity in _config.EntityCycles.Select(c => c))
		{
			entity.TurnOff();
		}

		_subscription?.Dispose();
	}
}
