using HomeAutomations.Models.Generated;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.LightsSchedule;

public class CycleInfo : IDisposable
{
	private int? _currentIndex;

	private readonly CycleConfig _config;
	private readonly IDisposable? _subscription;

	public CycleInfo(CycleConfig config)
	{
		_config = config;

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

		if (previousIndex != null)
		{
			foreach (var entity in _config.EntityCycles[previousIndex.Value])
			{
				entity.TurnOff();
			}
		}

		foreach (var entity in _config.EntityCycles[_currentIndex.Value])
		{
			entity.TurnOn();
		}
	}

	private int RotateIndex()
	{
		if (_currentIndex == null || _currentIndex >= _config.EntityCycles.Count - 1)
		{
			return 0;
		}

		return _currentIndex.Value + 1;
	}

	public void Dispose()
	{
		_subscription?.Dispose();
	}
}
