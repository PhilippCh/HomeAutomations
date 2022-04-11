using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.WaterCounter;

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
		CreateEntities();
		Context.Events.GetMobileNotificationActions(a => a.StartsWith(WaterNotificationActionPrefix))
			.Select(a => a[a.IndexOf(WaterNotificationActionPrefix, StringComparison.InvariantCulture)..])
			.Select(int.Parse)
			.Subscribe(OnAddWater);

		//(await _mqttService.GetMessagesForTopic<ButtonDeviceMessage>(Config.CounterTopic)).Subscribe(OnButtonPressed);
	}

	private async void CreateEntities()
	{
		/*var users = Context.await _entityManager.CreateAsync(Config.EntityId, new EntityCreationOptions("power", Config.EntityId, $"Current training schedule"));
		await _entityManager.SetStateAsync(Config.EntityId, "See entity attributes.");
		await _entityManager.SetAttributesAsync(Config.EntityId, GetEntityAttributes(schedule));*/
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
