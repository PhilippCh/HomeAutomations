using HomeAutomations.Models.Generated;
using NetDaemon.HassModel;

namespace HomeAutomations.Tests.Helpers;

public class TestEntityBuilder(IHaContext haContext)
{
	public BinarySensorEntity CreateBinarySensor(string entityId) => new(haContext, $"binary_sensor.{entityId}");
	public SensorEntity CreateSensor(string entityId) => new(haContext, $"sensor.{entityId}");
	public CoverEntity CreateCover(string entityId) => new(haContext, $"cover.{entityId}");
	public LightEntity CreateLight(string entityId) => new(haContext, $"light.{entityId}");
}
