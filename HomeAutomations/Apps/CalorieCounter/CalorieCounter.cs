using System;
using System.Reactive.Linq;
using System.Text.Json;
using HomeAssistant.Automations.Models;
using HomeAssistantGenerated;
using NetDaemon.Common;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Common;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

[NetDaemonApp]
public class CalorieCounter : BaseAutomation<CalorieCounter, CalorieCounterConfig>
{
	private const string HealthEventType = "health_event";

	private readonly IMqttEntityManager _entityManager;
	private readonly Entities _entities;

	public CalorieCounter(BaseAutomationDependencyAggregate<CalorieCounter, CalorieCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entities = new Entities(Context);
		_entityManager = entityManager;
	}

	protected override void Start()
	{
		Context.Events.Filter<HealthEventData>(HealthEventType).Subscribe(e => UpdateBaseCaloriesForUser(e.Data));
	}

	private async void UpdateBaseCaloriesForUser(HealthEventData? e)
	{
		if (e == null)
		{
			return;
		}

		var sensorId = GetBaseCaloriesSensorId(e.User);
		var total = e.RestingCalories + e.ActiveCalories;

		await _entityManager.CreateAsync("sensor", sensorId, "power", $"Base calories for {e.User}");
		await _entityManager.UpdateAsync("sensor", sensorId, total?.ToString() ?? "unknown", GetCaloriesAttributes(e));
	}

	private string GetBaseCaloriesSensorId(string? user) => $"calories_base_{user}";

	private string GetCaloriesAttributes(HealthEventData e) => JsonSerializer.Serialize(new { resting_kcal = e.RestingCalories, active_kcal = e.ActiveCalories });
}
