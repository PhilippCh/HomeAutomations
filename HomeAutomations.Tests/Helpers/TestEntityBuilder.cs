using HomeAutomations.Models.Generated;
using NetDaemon.HassModel;

namespace HomeAutomations.Tests.Helpers;

public class TestEntityBuilder(IHaContext haContext)
{
	public BinarySensorEntity CreateBinarySensor(string entityId) => new(haContext, entityId);
	public SensorEntity CreateSensor(string entityId) => new(haContext, entityId);
}
