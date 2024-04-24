using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using FluentAssertions;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Tests.Extensions;
using Microsoft.Reactive.Testing;
using Xunit;

namespace HomeAutomations.Tests.Tests.Extensions;

public class ObservableExtensionTests(TestScheduler testScheduler)
{
	[Fact]
	public void EmitDelayed_ShouldEmitOnceIfSameValue()
	{
		var delay = TimeSpan.FromMinutes(5);
		var sut = CreateSut<bool>(x => x == false, out var results, delay);

		sut.OnNext(false);
		sut.OnNext(false);
		AdvanceAndCheckResults(delay, results, [false]);
	}

	[Fact]
	public void EmitDelayed_ShouldUseDelayForPredicate()
	{
		var delay = TimeSpan.FromMinutes(5);
		var sut = CreateSut<bool>(x => x == false, out var results, delay);

		// True should be emitted immediately.
		sut.OnNext(true);
		AdvanceAndCheckResults(TimeSpan.FromMilliseconds(1), results, [true]);

		// False should be emitted after 5 minutes.
		sut.OnNext(false);
		AdvanceAndCheckResults(delay, results, [true, false]);
	}

	[Fact]
	public void EmitDelayed_ShouldOutputTrueIfPredicateExpires()
	{
		var delay = TimeSpan.FromMinutes(5);
		var sut = CreateSut<bool>(x => x == false, out var results, delay);

		// True should be emitted immediately.
		sut.OnNext(true);
		AdvanceAndCheckResults(TimeSpan.FromMilliseconds(1), results, [true]);

		// False should be emitted after 5 minutes, but emission should be immediately cancelled by emitting True.
		sut.OnNext(false);
		sut.OnNext(true);
		AdvanceAndCheckResults(delay, results, [true]);
	}

	[Fact]
	public void EmitDelayed_ShouldWorkForComplexSequence()
	{
		var delay = TimeSpan.FromMinutes(5);
		var sut = CreateSut<bool>(x => x == false, out var results, delay);

		// True should be emitted immediately.
		sut.OnNext(true);
		AdvanceAndCheckResults(delay, results, [true]);

		// Emitting the same value should result in no change.
		sut.OnNext(true);
		AdvanceAndCheckResults(delay, results, [true]);

		// Emitting False should only be emitted after 5 minutes.
		sut.OnNext(false);
		AdvanceAndCheckResults(delay - TimeSpan.FromMinutes(1), results, [true]);
		AdvanceAndCheckResults(delay, results, [true, false]);

		// Emitting True should emit immediately.
		sut.OnNext(true);
		AdvanceAndCheckResults(TimeSpan.FromMilliseconds(1), results, [true, false, true]);

		// Emitting False should be cancelled by emitting True.
		sut.OnNext(false);
		AdvanceAndCheckResults(delay - TimeSpan.FromMinutes(1), results, [true, false, true]);

		sut.OnNext(true);
		AdvanceAndCheckResults(delay, results, [true, false, true]);
	}

	[Fact]
	public void EmitDelayed_ShouldEmitAfterCustomDefaultDelay()
	{
		var filterDelay = TimeSpan.FromMinutes(5);
		var defaultDelay = TimeSpan.FromMinutes(2);
		var sut = CreateSut<bool>(x => x == false, out var results, filterDelay, defaultDelay);

		sut.OnNext(true);
		AdvanceAndCheckResults(TimeSpan.FromMilliseconds(1), results, []);
		AdvanceAndCheckResults(defaultDelay, results, [true]);
	}

	[Fact]
	public void EmitDelayed_ShouldEmitForBothCustomDelays()
	{
		var filterDelay = TimeSpan.FromMinutes(5);
		var defaultDelay = TimeSpan.FromMinutes(2);
		var sut = CreateSut<bool>(x => x == false, out var results, filterDelay, defaultDelay);

		sut.OnNext(true);
		AdvanceAndCheckResults(defaultDelay, results, [true]);

		sut.OnNext(false);
		AdvanceAndCheckResults(defaultDelay, results, [true]);
		AdvanceAndCheckResults(filterDelay, results, [true, false]);
	}

	private Subject<T> CreateSut<T>(Func<T, bool> predicate, out List<T> results, TimeSpan filterDelay, TimeSpan? defaultDelay = null)
	{
		var subject = new Subject<T>();
		subject.EmitDelayed(predicate, filterDelay, defaultDelay, testScheduler).SubscribeAndCapture(out results);

		return subject;
	}

	private void AdvanceAndCheckResults<T>(TimeSpan timeSpan, IEnumerable<T> results, ICollection<T> expectedResults)
	{
		testScheduler.AdvanceBy(timeSpan.Ticks);

		results.Should()
			.HaveCount(expectedResults.Count)
			.And.ContainInOrder(expectedResults);
	}
}
