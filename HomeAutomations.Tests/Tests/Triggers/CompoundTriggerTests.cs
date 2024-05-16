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
	[Fact]
	public void ShouldReturnTrueBetweenStartAndEnd()
	{
		var start = new Subject<bool>();
		var end = new Subject<bool>();
		var sut = new CompoundTrigger
		{
			Start = start,
			End = end
		};
		sut.AsObservable().SubscribeAndCapture(out var results);

		start.OnNext(true);
		results.Should().HaveCount(1).And.ContainInOrder(true);

		end.OnNext(true);
		results.Should().HaveCount(2).And.ContainInOrder(true, false);

		start.OnNext(false);
		results.Should().HaveCount(2).And.ContainInOrder(true, false);

		start.OnNext(true);
		results.Should().HaveCount(3).And.ContainInOrder(true, false, true);

		start.OnNext(false);
		end.OnNext(false);
		results.Should().HaveCount(4).And.ContainInOrder(true, false, true, false);
	}
}
