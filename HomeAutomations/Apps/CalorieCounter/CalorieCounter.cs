using System.Globalization;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Constants;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.CalorieCounter;

public class CalorieCounter : BaseAutomation<CalorieCounter>
{
	private const string BaseCaloriesId = "base";
	private const string DigestedCaloriesId = "digested";

	private readonly IMqttEntityManager _entityManager;

	public CalorieCounter(BaseAutomationDependencyAggregate<CalorieCounter> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events.Filter<HealthEventData>(HealthEventData.Id).Subscribe(e => UpdateBaseCaloriesForUser(e.Data));
		Context.Events.Filter<DigestCaloriesEventData>(DigestCaloriesEventData.Id).Subscribe(e => DigestCaloriesForUser(e.Data));

		return Task.CompletedTask;
	}

	private static string GetCaloriesSensorId(string? user, string prefix) => $"sensor.{prefix}_calories_for_{user}";

	private static string GetBaseCaloriesAttributes(HealthEventData e) => JsonSerializer.Serialize(new { resting_kcal = e.RestingCalories, active_kcal = e.ActiveCalories });

	private async void UpdateBaseCaloriesForUser(HealthEventData? e)
	{
		if (e == null)
		{
			return;
		}

		var sensorId = GetCaloriesSensorId(e.User, BaseCaloriesId);
		var total = e.RestingCalories + e.ActiveCalories;

		await _entityManager.CreateAsync(sensorId, new EntityCreationOptions(null, sensorId, $"Base calories for {e.User}"));
		await _entityManager.SetStateAsync(sensorId, total?.ToString(CultureInfo.InvariantCulture) ?? EntityStates.Unknown);
		await _entityManager.SetAttributesAsync(sensorId, GetBaseCaloriesAttributes(e));
	}

	private async void DigestCaloriesForUser(DigestCaloriesEventData? e)
	{
		if (e == null)
		{
			return;
		}

		var sensorId = GetCaloriesSensorId(e.User, DigestedCaloriesId);
		var sensor = new SensorEntity(Context, sensorId);

		if (!double.TryParse(sensor.State, out var total))
		{
			total = 0;
		}

		if (!double.TryParse(e.Calories?.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out var calories))
		{
			calories = 0;
		}

		total += calories;

		await _entityManager.CreateAsync(sensorId, new EntityCreationOptions(null, sensorId, $"Digested calories for {e.User}"));
		await _entityManager.SetStateAsync(sensorId, total.ToString(CultureInfo.InvariantCulture));
	}
}
