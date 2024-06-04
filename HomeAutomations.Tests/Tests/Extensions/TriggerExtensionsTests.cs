using System.Collections.Generic;
using FluentAssertions;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Tests.Extensions;
using HomeAutomations.Tests.Helpers;
using Xunit;

namespace HomeAutomations.Tests.Tests.Extensions;

public class TriggerExtensionsTests
{
	private readonly TestTrigger _startTrigger = new();
	private readonly TestTrigger _endTrigger = new();

	[Fact]
	public void WithEnd_EndShouldTrigger()
	{
		_startTrigger.WithEnd(_endTrigger).SubscribeAndCapture(out var results);

		SetStartEndAndCheckResult(false, false, [], results);
		SetStartEndAndCheckResult(true, false, [true], results);
		SetStartEndAndCheckResult(false, false, [true], results);
		SetStartEndAndCheckResult(false, true, [true, false], results);
	}

	[Fact]
	public void WithEnd_EndShouldTrigger_WithStartTrue()
	{
		_startTrigger.WithEnd(_endTrigger).SubscribeAndCapture(out var results);

		SetStartEndAndCheckResult(false, false, [], results);
		SetStartEndAndCheckResult(true, false, [true], results);
		SetStartEndAndCheckResult(true, true, [true, false], results);
	}

	[Fact]
	public void WithEnd_EndShouldTrigger_ComplexExample()
	{
		_startTrigger.WithEnd(_endTrigger).SubscribeAndCapture(out var results);

		SetStartEndAndCheckResult(false, false, [], results);
		SetStartEndAndCheckResult(true, false, [true], results);
		SetStartEndAndCheckResult(true, true, [true, false], results);

		SetStartEndAndCheckResult(false, false, [true, false], results);
		SetStartEndAndCheckResult(true, false, [true, false, true], results);
		SetStartEndAndCheckResult(false, false, [true, false, true], results);
		SetStartEndAndCheckResult(false, true, [true, false, true, false], results);
		SetStartEndAndCheckResult(false, false, [true, false, true, false], results);
		SetStartEndAndCheckResult(true, false, [true, false, true, false, true], results);
	}

	private void SetStartEndAndCheckResult(bool? start, bool? end, List<bool> expectedResults, List<bool> results)
	{
		if (start.HasValue)
		{
			_startTrigger.Subject.OnNext(start.Value);
		}

		if (end.HasValue)
		{
			_endTrigger.Subject.OnNext(end.Value);
		}

		results.Should()
			.HaveCount(expectedResults.Count)
			.And.ContainInOrder(results);
	}
}
