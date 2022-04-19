﻿using HomeAutomations.Apps.Counters.WaterCounter;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.KratomCounter;

public record KratomCounterConfig : CounterConfig;

public class KratomCounter : BaseCounter<KratomCounter, KratomCounterConfig>
{
	public KratomCounter(BaseAutomationDependencyAggregate<KratomCounter, KratomCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate, entityManager)
	{
	}
}
