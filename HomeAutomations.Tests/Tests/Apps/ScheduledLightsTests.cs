using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;
using HomeAutomations.Apps.Lights.ScheduledLights;
using HomeAutomations.Common.Triggers;
using HomeAutomations.Services;
using HomeAutomations.Tests.Helpers;
using HomeAutomations.Tests.Mocks;
using Microsoft.Extensions.Options;
using Microsoft.Reactive.Testing;
using Moq;
using Serilog;
using Xunit;

namespace HomeAutomations.Tests.Tests.Apps;

public class ScheduledLightsTests
{
	private class TestTrigger : ITrigger
	{
		public string? Id { get; init; }
		public bool LatestValue { get; private set; }
		public readonly Subject<bool> Subject = new();

		public IObservable<bool> AsObservable() => Subject.Do(x => LatestValue = x);

		public IEnumerable<ITrigger> GetTriggersInternal() => [];
	}

	private const string TestLightEntityId = "TestLight1";

	private readonly StateChangeManager _stateChangeManager;
	private readonly TestScheduler _testScheduler;

	private readonly Mock<EntityStatePriorityManager> _entityStatePriorityManagerMock = new();
	private readonly Mock<TriggerRepository> _triggerRepositoryMock;

	private readonly ScheduledLights _sut;

	public ScheduledLightsTests(
		TestEntityBuilder testEntityBuilder,
		TestAppBuilder testAppBuilder,
		StateChangeManager stateChangeManager,
		TestScheduler testScheduler)
	{
		_stateChangeManager = stateChangeManager;
		_testScheduler = testScheduler;

		var triggerRepositoryOptions = Options.Create(new TriggerRepositoryConfig());
		_triggerRepositoryMock = new Mock<TriggerRepository>(triggerRepositoryOptions, Mock.Of<IServiceProvider>(), Mock.Of<ILogger>()) { CallBase = true };

		var config = new ScheduledLightsConfig
		{
			LightCycles = new[]
			{
				new CycleConfig
				{
					Name = "Test",
					StartTriggerId = "TestStart",
					EndTriggerId = "TestEnd",
					Interval = TimeSpan.FromMinutes(5),
					EntityCycles = new[]
					{
						new[]
						{
							testEntityBuilder.CreateLight(TestLightEntityId)
						}
					},
				}
			}
		};

		var aggregate = testAppBuilder.CreateAppAggregate<ScheduledLights, ScheduledLightsConfig>(config);
		_sut = new ScheduledLights(aggregate, _entityStatePriorityManagerMock.Object, _triggerRepositoryMock.Object);
	}

	[Fact]
	public async Task ShouldInitializeAsync()
	{
		var startTrigger = new TestTrigger();
		var endTrigger = new TestTrigger();

		_triggerRepositoryMock
			.Setup(x => x.GetTrigger(It.IsAny<string>()))
			.Returns(
				(string x) => x switch
				{
					"TestStart" => startTrigger,
					"TestEnd" => endTrigger,
					_ => null
				});

		await _sut.InitializeAsync(CancellationToken.None);
		await Task.Delay(TimeSpan.FromSeconds(5));

		SetStartEndAndAdvanceScheduler(startTrigger, endTrigger, startValue: true);
		AssertLatestServiceCallAndCount("turn_on", 1);

		SetStartEndAndAdvanceScheduler(startTrigger, endTrigger, endValue: true);
		AssertLatestServiceCallAndCount("turn_off", 2);

		SetStartEndAndAdvanceScheduler(startTrigger, endTrigger, startValue: false);
		AssertLatestServiceCallAndCount("turn_off", 2);

		SetStartEndAndAdvanceScheduler(startTrigger, endTrigger, startValue: true);
		AssertLatestServiceCallAndCount("turn_on", 3);
	}

	private void SetStartEndAndAdvanceScheduler(TestTrigger start, TestTrigger end, bool? startValue = null, bool? endValue = null)
	{
		if (startValue.HasValue)
		{
			start.Subject.OnNext(startValue.Value);
		}

		if (endValue.HasValue)
		{
			end.Subject.OnNext(endValue.Value);
		}

		_stateChangeManager.AdvanceBy(TimeSpan.FromMinutes(1));
	}

	private void AssertLatestServiceCallAndCount(string expectedService, int expectedCount)
	{
		using (new AssertionScope())
		{
			_stateChangeManager.ServiceCalls.Should().HaveCount(expectedCount);
			_stateChangeManager.LastServiceCall.Should().NotBeNull();
			_stateChangeManager.LastServiceCall.Service.Should().Be(expectedService);
		}
	}
}
