using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.WaterCounter;

public record WaterCounterConfig : CounterConfig;

// DO NOT REMOVE
// When debugging, this allows for counters to still work.
[Focus]
public class WaterCounter(BaseAutomationDependencyAggregate<WaterCounter, WaterCounterConfig> aggregate, IMqttEntityManager entityManager)
	: BaseCounter<WaterCounter, WaterCounterConfig>(aggregate, entityManager);
