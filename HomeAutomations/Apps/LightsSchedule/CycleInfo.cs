using HomeAutomations.Models.Generated;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.LightsSchedule;

public class CycleInfo
{
	public CycleConfig Cycle { get; }
	public IDisposable Subscription { get; }

	private int? _currentIndex;

	public CycleInfo(CycleConfig cycle)
	{
		Cycle = cycle;
		Subscription = ObservableExtensions.Interval(cycle.Interval, true).Subscribe(_ => Update());
	}

	private void Update()
	{
		var previousIndex = _currentIndex;
		_currentIndex = RotateIndex();

		if (previousIndex != null)
		{
			foreach (var entity in Cycle.EntityCycles[previousIndex.Value])
			{
				entity.TurnOff();
			}
		}

		foreach (var entity in Cycle.EntityCycles[_currentIndex.Value])
		{
			entity.TurnOn();
		}
	}

	private int RotateIndex()
	{
		if (_currentIndex == null || _currentIndex >= Cycle.EntityCycles.Count - 1)
		{
			return 0;
		}

		return _currentIndex.Value + 1;
	}
}
