using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using HomeAutomations.Apps.VirtualEntities.Entities;
using HomeAutomations.Models.Generated;
using HomeAutomations.Tests.Helpers;
using Moq;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel;
using Serilog;
using Xunit;

namespace HomeAutomations.Tests.Tests.Apps.VirtualEntities;

public class SleepStateEntityTests
{
	private readonly StateChangeManager _stateChangeManager;

	private readonly SleepStateEntity _sut;
	private readonly List<BinarySensorEntity> _presenceSensors;
	private readonly List<SensorEntity> _chargingSensors;
	private readonly Mock<IMqttEntityManager> _mqttEntityManagerMock = new();
	private readonly Mock<ILogger> _loggerMock = new();

	public SleepStateEntityTests(TestEntityBuilder testEntityBuilder, StateChangeManager stateChangeManager)
	{
		_stateChangeManager = stateChangeManager;

		_presenceSensors = [testEntityBuilder.CreateBinarySensor("binary_sensor.presence_sensor_1_unit_test")];
		_chargingSensors = [testEntityBuilder.CreateSensor("sensor.smartphone_battery_state_1_unit_test")];

		var config = new SleepStateEntityConfig
		{
			BedPresenceSensors = _presenceSensors,
			SmartphoneChargingSensors = _chargingSensors
		};

		_sut = new SleepStateEntity("binary_sensor.sleep_state_unit_test", config, _mqttEntityManagerMock.Object, _loggerMock.Object);
	}

	[Fact]
	public async Task ShouldInitializeAppAsync()
	{
		_sut.StateChanges().Subscribe(x => Debug.WriteLine(x));

		_stateChangeManager.Change(_presenceSensors.First(), "on");
		_stateChangeManager.AdvanceTo(DateTime.Now + TimeSpan.FromMinutes(6));
	}
}
