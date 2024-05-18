using System;
using System.Reactive.Subjects;
using FluentAssertions;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Tests.Extensions;
using Microsoft.Reactive.Testing;
using Xunit;

namespace HomeAutomations.Tests.Tests.Triggers;

public class CompoundTriggerTests(TestScheduler testScheduler)
{
	private class TestTrigger : ITrigger
	{
		public IObservable<bool> AsObservable() => _subject;

		private readonly Subject<bool> _subject = new();

		public void Trigger(bool value) => _subject.OnNext(value);
	}

	[Fact]
	public void ShouldReturnTrueBetweenStartAndEnd()
	{
		var start = new TestTrigger();
		var end = new TestTrigger();
		var sut = new CompoundTrigger
		{
			Start = start,
			End = end
		};
		sut.AsObservable().SubscribeAndCapture(out var results);

		start.Trigger(true);
		results.Should().HaveCount(1).And.ContainInOrder(true);

		end.Trigger(true);
		results.Should().HaveCount(2).And.ContainInOrder(true, false);

		start.Trigger(false);
		results.Should().HaveCount(2).And.ContainInOrder(true, false);

		start.Trigger(true);
		results.Should().HaveCount(3).And.ContainInOrder(true, false, true);

		start.Trigger(false);
		end.Trigger(false);
		results.Should().HaveCount(4).And.ContainInOrder(true, false, true, false);
	}
}
