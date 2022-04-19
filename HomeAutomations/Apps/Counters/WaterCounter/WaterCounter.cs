﻿using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.Counters.WaterCounter;

public record WaterCounterConfig : CounterConfig;

public class WaterCounter : BaseCounter<WaterCounter, WaterCounterConfig>
{
	public WaterCounter(BaseAutomationDependencyAggregate<WaterCounter, WaterCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate, entityManager)
	{
	}
}
