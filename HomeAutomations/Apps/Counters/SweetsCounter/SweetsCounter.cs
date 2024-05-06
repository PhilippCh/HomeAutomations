using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.SweetsCounter;

public record SweetsCounterConfig : CounterConfig;

// DO NOT REMOVE
// When debugging, this allows for counters to still work.
[Focus]
public class SweetsCounter(BaseAutomationDependencyAggregate<SweetsCounter, SweetsCounterConfig> aggregate, IMqttEntityManager entityManager)
	: BaseCounter<SweetsCounter, SweetsCounterConfig>(aggregate, entityManager);
