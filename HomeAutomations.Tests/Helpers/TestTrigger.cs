using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAutomations.Common.Triggers;

namespace HomeAutomations.Tests.Helpers;

public class TestTrigger : ITrigger
{
	public string? Id { get; init; }
	public bool LatestValue { get; private set; }
	public readonly Subject<bool> Subject = new();

	public IObservable<bool> AsObservable() => Subject.Do(x => LatestValue = x);

	public IEnumerable<ITrigger> GetTriggersInternal() => [];
}
