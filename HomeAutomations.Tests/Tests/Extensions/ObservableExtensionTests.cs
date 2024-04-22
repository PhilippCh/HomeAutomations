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
		var sut = CreateSut<bool>(x => x == false, delay, out var results);

		sut.OnNext(false);
		sut.OnNext(false);

		testScheduler.AdvanceBy(delay.Ticks);

		results.Should().HaveCount(1);
		results.Should().AllSatisfy(x => x.Should().BeFalse());
	}

	[Fact]
	public void EmitDelayed_ShouldUseDelayForPredicate()
	{
		var delay = TimeSpan.FromMinutes(5);
		var sut = CreateSut<bool>(x => x == false, delay, out var results);

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
		var sut = CreateSut<bool>(x => x == false, delay, out var results);

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
		var sut = CreateSut<bool>(x => x == false, delay, out var results);

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

	private Subject<T> CreateSut<T>(Func<T, bool> predicate, TimeSpan delay, out List<T> results)
	{
		var subject = new Subject<T>();
		subject.EmitDelayed(predicate, delay, testScheduler).SubscribeAndCapture(out results);

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
