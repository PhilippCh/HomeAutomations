using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Extensions;

namespace HomeAutomations.Common.Triggers;

public class CompoundTrigger
{
	public IObservable<bool> Start
	{
		init
		{
			_start = value;
			_startObserver?.Dispose();
			_startObserver = _start.Where(x => x).Subscribe(_ => _subject.OnNext(true));
		}
	}

	public IObservable<bool> End
	{
		init
		{
			_end = value;
			_endObserver?.Dispose();
			_endObserver = _end.Where(x => x).Subscribe(_ => _subject.OnNext(false));
		}
	}

	private readonly IObservable<bool> _end = null!;
	private readonly IObservable<bool> _start = null!;
	private readonly IDisposable? _startObserver;
	private readonly IDisposable? _endObserver;
	private readonly Subject<bool> _subject = new();

	public IObservable<bool> AsObservable() => _start
		.SwitchMap(x => x ? _end.Select(y => !y).StartWith(true) : false.AsObservable())
		.DistinctUntilChanged();
}
