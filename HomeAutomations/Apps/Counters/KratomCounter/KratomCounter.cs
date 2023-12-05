using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.KratomCounter;

public record KratomCounterConfig : CounterConfig;

// DO NOT REMOVE
// When debugging, this allows for counters to still work.
[Focus]
public class KratomCounter : BaseCounter<KratomCounter, KratomCounterConfig>
{
	public KratomCounter(BaseAutomationDependencyAggregate<KratomCounter, KratomCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate, entityManager)
	{
	}
}
