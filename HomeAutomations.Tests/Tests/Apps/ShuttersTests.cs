using System;
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
using HomeAutomations.Services.Interfaces;
using HomeAutomations.Tests.Helpers;
using Microsoft.Reactive.Testing;
using Moq;
using NetDaemon.Extensions.MqttEntityManager;
using Xunit;

namespace HomeAutomations.Tests.Tests.Apps;

public class ShuttersTests : IAsyncLifetime
{
	private readonly StateChangeManager _stateChangeManager;

	private readonly Shutters _sut;
	private readonly BinarySensorEntity _windowOpenSensor;
	private readonly Mock<IMqttEntityManager> _mqttEntityManagerMock = new();
	private readonly Mock<INotificationService> _notificationServiceMock = new();

	private readonly ShuttersConfig _defaultConfig;

	public ShuttersTests(
		TestEntityBuilder testEntityBuilder,
		TestAppBuilder testAppBuilder,
		StateChangeManager stateChangeManager,
		TestScheduler testScheduler)
	{
		_stateChangeManager = stateChangeManager;
		_windowOpenSensor = testEntityBuilder.CreateBinarySensor("binary_sensor.window_open_sensor_unit_test");
		_defaultConfig = new ShuttersConfig
		{
			Latitude = AppConstants.Latitude,
			Longitude = AppConstants.Longitude,
			OpenTime = new TimeConfig
			{
				Hour = "00:08:00",
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

		var aggregate = testAppBuilder.CreateAppAggregate<Shutters, ShuttersConfig>(_defaultConfig);
		_sut = new Shutters(aggregate, _notificationServiceMock.Object, _mqttEntityManagerMock.Object, testScheduler);
	}

	public async Task InitializeAsync()
	{
		await _sut.InitializeAsync(CancellationToken.None);
	}

	public Task DisposeAsync() => Task.CompletedTask;

	[Fact]
	public async Task ShouldCreateOpenShuttersEntityAsync()
	{
		_mqttEntityManagerMock.VerifyCreateEntity(_defaultConfig.OpenShuttersSensorEntity.EntityId, "Open shutters sensor");
	}

	[Fact]
	public async Task ShouldCloseShuttersAfterSunsetWithDelayAsync()
	{
		var celestial = new Celestial(_defaultConfig.Latitude, _defaultConfig.Longitude, DateTime.Now, 0);
		var sunset = celestial.SunSet!.Value; // The sun always sets in Neuburg, so we can ignore null values.

		_stateChangeManager.Change(_windowOpenSensor, "off");
		_stateChangeManager.AdvanceTo(DateTime.Now.AddMinutes(1));

		_stateChangeManager.ServiceCalls.Should()
			.BeEquivalentTo(_defaultConfig.Shutters.Select(x => Events.Cover.Close(x.Entity)));
	}
}
