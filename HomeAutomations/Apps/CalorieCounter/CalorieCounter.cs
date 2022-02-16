using System;
using System.Globalization;
using System.Text.Json;
using HomeAssistant.Automations.Attributes;
using HomeAssistant.Automations.Models;
using HomeAssistantGenerated;
using NetDaemon.Common;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Common;

namespace HomeAssistant.Automations.Apps.CalorieCounter;

[Focus]
public class CalorieCounter : BaseAutomation<CalorieCounter, CalorieCounterConfig>
{
	private const string DigestCaloriesEventType = "digest_calories_event";
	private const string HealthEventType = "health_event";

	private const string BaseCaloriesId = "base";
	private const string DigestedCaloriesId = "digested";

	private readonly IMqttEntityManager _entityManager;

	public CalorieCounter(BaseAutomationDependencyAggregate<CalorieCounter, CalorieCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
	}

	protected override void Start()
	{
		Context.Events.Filter<HealthEventData>(HealthEventType).Subscribe(e => UpdateBaseCaloriesForUser(e.Data));
		Context.Events.Filter<DigestCaloriesEventData>(DigestCaloriesEventType).Subscribe(e => DigestCaloriesForUser(e.Data));
	}

	private static string GetCaloriesSensorId(string? user, string prefix) => $"{prefix}_calories_for_{user}";

	private static string GetBaseCaloriesAttributes(HealthEventData e) => JsonSerializer.Serialize(new { resting_kcal = e.RestingCalories, active_kcal = e.ActiveCalories });

	private async void UpdateBaseCaloriesForUser(HealthEventData? e)
	{
		if (e == null)
		{
			return;
		}

		var sensorId = GetCaloriesSensorId(e.User, BaseCaloriesId);
		var total = e.RestingCalories + e.ActiveCalories;

		await _entityManager.CreateAsync("sensor", sensorId, "power", $"Base calories for {e.User}");
		await _entityManager.UpdateAsync("sensor", sensorId, total?.ToString(CultureInfo.InvariantCulture) ?? "unknown", GetBaseCaloriesAttributes(e));
	}

	private async void DigestCaloriesForUser(DigestCaloriesEventData? e)
	{
		if (e == null)
		{
			return;
		}

		var sensorId = GetCaloriesSensorId(e.User, DigestedCaloriesId);
		var sensor = new SensorEntity(Context, $"sensor.{sensorId}");

		if (!double.TryParse(sensor.State, out var total))
		{
			total = 0;
		}

		if (!double.TryParse(e.Calories?.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out var calories))
		{
			calories = 0;
		}

		total += calories;

		await _entityManager.CreateAsync("sensor", sensorId, "power", $"Digested calories for {e.User}");
		await _entityManager.UpdateAsync("sensor", sensorId, total.ToString(CultureInfo.InvariantCulture));
	}
}
