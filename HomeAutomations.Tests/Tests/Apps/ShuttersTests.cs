using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoordinateSharp;
using FluentAssertions;
using HomeAutomations.Apps;
using HomeAutomations.Apps.Shutters;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using HomeAutomations.Tests.Helpers;
using HomeAutomations.Tests.Mocks;
using Microsoft.Reactive.Testing;
using Moq;
using NetDaemon.Extensions.MqttEntityManager;
using Xunit;

// ReSharper disable InconsistentNaming
namespace HomeAutomations.Tests.Tests.Apps;

[SuppressMessage("Style", "VSTHRD200")]
public class ShuttersTests : IAsyncLifetime
{
	private const string On = "ON";
	private const string Off = "OFF";

	private readonly TestAppBuilder _testAppBuilder;
	private readonly StateChangeManager _stateChangeManager;
	private readonly TestScheduler _testScheduler;
	private readonly ClockServiceMock _clockServiceMock;
	private readonly BinarySensorEntity _windowOpenSensor;
	private readonly Mock<IMqttEntityManager> _mqttEntityManagerMock = new();
	private readonly Mock<INotificationService> _notificationServiceMock = new();
	private readonly ShuttersConfig _config;

	private Shutters? _sut;
	private IEnumerable<string> _openShutterSensorStates;

	public ShuttersTests(
		TestEntityBuilder testEntityBuilder,
		TestAppBuilder testAppBuilder,
		StateChangeManager stateChangeManager,
		TestScheduler testScheduler,
		IClockService clockService)
	{
		_testAppBuilder = testAppBuilder;
		_stateChangeManager = stateChangeManager;
		_testScheduler = testScheduler;
		_clockServiceMock = (ClockServiceMock) clockService;
		_windowOpenSensor = testEntityBuilder.CreateBinarySensor("binary_sensor.window_open_sensor_unit_test");
		_config = new ShuttersConfig
		{
			Latitude = AppConstants.Latitude,
			Longitude = AppConstants.Longitude,
			OpenTime = new TimeConfig
			{
				Hour = "08:00:00",
				HourWeekend = "12:00:00",
				IncludeFriday = false
			},
			OpenDelay = TimeSpan.FromMinutes(15),
			CloseDelay = TimeSpan.FromMinutes(15),
			OpenSensorEntity = testEntityBuilder.CreateSensor("bedroom_bedside_light_switch_philipp_action_test"),
			OpenShuttersSensorEntity = testEntityBuilder.CreateBinarySensor("bedroom_open_shutters_test"),
			SleepStateEntity = testEntityBuilder.CreateBinarySensor("presence_bedroom_is_anyone_sleeping_test"),
			SleepStateDebugNotification = new Notification
			{
				Title = "Shutters",
				Template = "Opening shutters automatically due to no one sleeping anymore.",
				Service = "mobile_app_iphone_philipp"
			},
			Shutters = new[]
			{
				new ShutterConfig
				{
					Entity = testEntityBuilder.CreateCover("bedroom_roller_shutter_left_test"),
					ForceOpenOverride = _windowOpenSensor
				},
				new ShutterConfig
				{
					Entity = testEntityBuilder.CreateCover("bedroom_roller_shutter_right_test"),
					ForceOpenOverride = _windowOpenSensor
				}
			}
		};
	}

	public async Task InitializeAsync()
	{
		var aggregate = _testAppBuilder.CreateAppAggregate<Shutters, ShuttersConfig>(_config);
		_sut = new Shutters(aggregate, _notificationServiceMock.Object, _mqttEntityManagerMock.Object, _clockServiceMock, _testScheduler);
		_openShutterSensorStates = _mqttEntityManagerMock.CaptureSetState(_config.OpenShuttersSensorEntity.EntityId);

		await _sut.InitializeAsync(CancellationToken.None);
	}

	public Task DisposeAsync() => Task.CompletedTask;

	[Fact]
	public void Common_ShouldCreateOpenShuttersEntity()
	{
		_mqttEntityManagerMock.VerifyCreateEntity(_config.OpenShuttersSensorEntity.EntityId, "Open shutters sensor");
	}

	[Fact]
	public void Closing_ShouldKeepOpenBeforeSunset()
	{
		var date = new DateTime(2024, 5, 6, 17, 0, 0);
		var celestial = new Celestial(_config.Latitude, _config.Longitude, DateTime.Now, TimeZoneInfo.Local.GetUtcOffset(date).TotalHours);
		var sunset = celestial.SunSet!.Value; // The sun always sets in Neuburg, so we can ignore null values.

		SetNowAndAdvanceScheduler(date);
		_stateChangeManager.ServiceCalls.Should().BeEmpty();

		SetNowAndAdvanceScheduler(sunset.AddSeconds(-1));
		_stateChangeManager.ServiceCalls.Should().BeEmpty();
	}

	[Fact]
	public void Closing_ShouldCloseAfterSunsetWithDelay()
	{
		var date = new DateTime(2024, 5, 6, 17, 0, 0);
		var celestial = new Celestial(_config.Latitude, _config.Longitude, DateTime.Now, TimeZoneInfo.Local.GetUtcOffset(date).TotalHours);
		var sunset = celestial.SunSet!.Value; // The sun always sets in Neuburg, so we can ignore null values.

		SetNowAndAdvanceScheduler(date);
		_stateChangeManager.ServiceCalls.Should().BeEmpty();

		// Wait until sunset. Advance by close delay + 1 minute because IntervalSunset only checks for changes once every minute.
		SetNowAndAdvanceScheduler(sunset.AddSeconds(1), _config.CloseDelay + TimeSpan.FromMinutes(1));
		_stateChangeManager.ServiceCalls.Should()
			.BeEquivalentTo(_config.Shutters.Select(x => Events.Cover.Close(x.Entity)));
	}

	[Fact]
	public void Opening_ShouldKeepClosedIfTooEarly()
	{
		var date = new DateTime(2024, 5, 6, 7, 0, 0);
		_stateChangeManager.Change(_config.SleepStateEntity, Off); // No one is sleeping.
		SetNowAndAdvanceScheduler(date);

		Assert.Equal(new[] { Off }, _openShutterSensorStates);
	}

	[Fact]
	public void Opening_ShouldKeepClosedIfTooEarlyAndStillSleeping()
	{
		var date = new DateTime(2024, 5, 6, 7, 0, 0);
		_stateChangeManager.Change(_config.SleepStateEntity, On); // Someone is still sleeping.
		SetNowAndAdvanceScheduler(date);

		Assert.Equal(new[] { Off }, _openShutterSensorStates);
	}

	[Fact]
	public void Opening_ShouldKeepClosedIfAfterOpeningTimeButStillSleeping()
	{
		var date = new DateTime(2024, 5, 6, 10, 0, 0);
		_stateChangeManager.Change(_config.SleepStateEntity, On); // Someone is still sleeping.
		SetNowAndAdvanceScheduler(date);

		Assert.Equal(new[] { Off }, _openShutterSensorStates);
	}

	[Fact]
	public void Opening_ShouldOpenIfAfterOpeningTime()
	{
		var date = new DateTime(2024, 5, 6, 7, 0, 0);
		_stateChangeManager.Change(_config.SleepStateEntity, Off); // No one is sleeping.
		SetNowAndAdvanceScheduler(date);

		Assert.Equal(new[] { Off }, _openShutterSensorStates);

		SetNowAndAdvanceScheduler(date.AddHours(1));

		Assert.Equal(new[] { Off, On }, _openShutterSensorStates);
	}

	[Fact]
	public void Opening_ShouldHandleComplexCase()
	{
		var date = new DateTime(2024, 5, 6, 2, 0, 0);
		_stateChangeManager.Change(_config.SleepStateEntity, Off);			// No one is sleeping.
		SetNowAndAdvanceScheduler(date);

		// No one is sleeping, but it's too early to open the shutters.
		Assert.Equal(new[] { Off }, _openShutterSensorStates);

		_stateChangeManager.Change(_config.SleepStateEntity, On);			// We are sleeping now.
		date = new DateTime(2024, 5, 6, 6, 37, 0);		// It's still before opening time.
		SetNowAndAdvanceScheduler(date);
		Assert.Equal(new[] { Off }, _openShutterSensorStates);

		date = new DateTime(2024, 5, 6, 12, 0, 0);		// It's now after opening time, but we are still sleeping.
		SetNowAndAdvanceScheduler(date);
		Assert.Equal(new[] { Off }, _openShutterSensorStates);

		_stateChangeManager.Change(_config.SleepStateEntity, Off);			// We are not sleeping anymore.
		SetNowAndAdvanceScheduler(date);
		Assert.Equal(new[] { Off, On }, _openShutterSensorStates);

		date = new DateTime(2024, 5, 7, 0, 0, 0);		// It's again before opening time, but we are not yet sleeping.
		SetNowAndAdvanceScheduler(date);
		Assert.Equal(new[] { Off, On, Off }, _openShutterSensorStates);

		date = new DateTime(2024, 5, 7, 9, 0, 0);		// It's after opening time, and we are not sleeping anymore.
		SetNowAndAdvanceScheduler(date);
		Assert.Equal(new[] { Off, On, Off, On }, _openShutterSensorStates);
	}

	private void SetNowAndAdvanceScheduler(DateTime now, TimeSpan? advanceBy = default)
	{
		_clockServiceMock.Now = now;
		_stateChangeManager.AdvanceBy(advanceBy ?? TimeSpan.FromMinutes(1));
	}
}
