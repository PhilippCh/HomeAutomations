using System;
using System.Collections.Generic;
using System.Globalization;
using FluentAssertions;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using HomeAutomations.Tests.Extensions;
using HomeAutomations.Tests.Helpers;
using HomeAutomations.Tests.Mocks;
using HomeAutomations.Triggers;
using Microsoft.Extensions.Options;
using Microsoft.Reactive.Testing;
using Moq;
using Serilog;
using Xunit;

namespace HomeAutomations.Tests.Tests.Triggers.Integration;

public class SunsetTriggerTests
{
	private readonly StateChangeManager _stateChangeManager;
	private readonly TestEntityBuilder _testEntityBuilder;
	private readonly ClockServiceMock _clockService;
	private readonly TriggerRepository _triggerRepository;

	private readonly ITrigger _sut;
	private readonly SensorEntity _illuminanceSensor;

	public SunsetTriggerTests(
		IServiceProvider serviceProvider,
		StateChangeManager stateChangeManager,
		TestEntityBuilder testEntityBuilder,
		TestScheduler testScheduler,
		IClockService clockService)
	{
		_stateChangeManager = stateChangeManager;
		_testEntityBuilder = testEntityBuilder;
		_clockService = (ClockServiceMock) clockService;
		_illuminanceSensor = _testEntityBuilder.CreateSensor("balcony_illuminance_test");

		_sut = new AndTrigger
		{
			Triggers = new ITrigger[]
			{
				new TimeTrigger(testScheduler, clockService)
				{
					From = TimeOnly.Parse("18:00:00"),
					To = TimeOnly.Parse("23:59:59")
				},
				new SensorEntityComparisonTrigger
				{
					Entity = _illuminanceSensor,
					Threshold = 200f
				}
			}
		};
	}

	[Fact]
	public void ShouldInitialize()
	{
		_sut.AsObservable().SubscribeAndCapture(out var invokes);

		// Still too bright outside and too early.
		_stateChangeManager.Change(_illuminanceSensor, 500f.ToString(CultureInfo.InvariantCulture));
		AdvanceAndCheckResults(DateTime.Today + TimeSpan.Parse("10:00:00"), invokes, [false]);

		// Dark enough, but still too early.
		_stateChangeManager.Change(_illuminanceSensor, 180f.ToString(CultureInfo.InvariantCulture));
		AdvanceAndCheckResults(DateTime.Today + TimeSpan.Parse("17:59:00"), invokes, [false]);

		// Good to go!
		_stateChangeManager.Change(_illuminanceSensor, 180f.ToString(CultureInfo.InvariantCulture));
		AdvanceAndCheckResults(DateTime.Today + TimeSpan.Parse("18:00:00"), invokes, [false, true]);
	}

	private void AdvanceAndCheckResults(DateTime time, List<bool> results, ICollection<bool> expectedResults)
	{
		_clockService.Now = time;
		_stateChangeManager.AdvanceTo(TimeOnly.FromDateTime(time));

		results.Should()
			.HaveCount(expectedResults.Count)
			.And.ContainInOrder(expectedResults);
	}
}
