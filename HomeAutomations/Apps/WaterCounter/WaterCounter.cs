using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.WaterCounter;

[Focus]
public class WaterCounter : BaseAutomation<WaterCounter, WaterCounterConfig>
{
	private const string WaterNotificationActionPrefix = "WATER_";

	private readonly MqttService _mqttService;
	private readonly NotificationService _notificationService;
	private readonly IMqttEntityManager _entityManager;

	public WaterCounter(
		MqttService mqttService,
		NotificationService notificationService,
		BaseAutomationDependencyAggregate<WaterCounter, WaterCounterConfig> aggregate,
		IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_notificationService = notificationService;
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		StartResetSchedule();
		await CreateEntities();
		Context.Events.GetMobileNotificationActions(a => a.StartsWith(WaterNotificationActionPrefix))
			.Select(a => a[a.IndexOf(WaterNotificationActionPrefix, StringComparison.InvariantCulture)..])
			.Select(int.Parse)
			.Subscribe(OnAddWater);

		//(await _mqttService.GetMessagesForTopic<ButtonDeviceMessage>(Config.CounterTopic)).Subscribe(OnButtonPressed);
	}

	private async Task CreateEntities()
	{
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			var entityId = $"{Config.EntityPrefix}{name}";
			await _entityManager.CreateAsync(entityId, new EntityCreationOptions(null, entityId, $"Daily water intake for {name}"));
		}
	}

	private async void StartResetSchedule()
	{
		await CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);
	}

	private void ResetCounter()
	{
		Logger.Information("Resetting daily water counters.");
		//Config.Counter.SetValue(0);
	}

	private void OnAddWater(int amountMl)
	{

	}
}
