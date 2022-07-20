using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.WaterCounter;

public record WaterCounterConfig : CounterConfig;

// DO NOT REMOVE
// When debugging, this allows for counters to still work.
[Focus]
public class WaterCounter : BaseCounter<WaterCounter, WaterCounterConfig>
{
	public WaterCounter(BaseAutomationDependencyAggregate<WaterCounter, WaterCounterConfig> aggregate, IMqttEntityManager entityManager, MqttService mqttService)
		: base(aggregate, entityManager, mqttService)
	{
	}
}
