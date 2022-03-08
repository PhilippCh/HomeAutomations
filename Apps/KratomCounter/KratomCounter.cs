using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.KratomCounter;

public class KratomCounter : BaseAutomation<KratomCounter, KratomCounterConfig>
{
	private const string KratomEventType = "kratom_event";

	private readonly MqttService _mqttService;
	private readonly NotificationService _notificationService;

	public KratomCounter(MqttService mqttService, NotificationService notificationService, BaseAutomationDependencyAggregate<KratomCounter, KratomCounterConfig> aggregate)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_notificationService = notificationService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		StartResetSchedule();
		Context.Events
			.Where(e => e.EventType == KratomEventType && e.DataElement.HasValue)
			.Select(e => int.Parse(e.DataElement?.GetProperty("value").GetString() ?? "0"))
			.Subscribe(Count);


		(await _mqttService.GetMessagesForTopic<ButtonDeviceMessage>(Config.CounterTopic)).Subscribe(OnButtonPressed);
	}

	private async void StartResetSchedule()
	{
		await CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);
	}

	private void ResetCounter()
	{
		Config.Counter.SetValue(0);
	}

	private void OnButtonPressed(ButtonDeviceMessage? message)
	{
		var action = message?.Action ?? ButtonAction.Undefined;

		// For every non-special action, increase counter by X.
		if (action != ButtonAction.Undefined && action < ButtonDeviceMessage.SpecialActionBegin)
		{
			Count((int) action);
		}

		// Decrease count by 1.
		if (action == ButtonAction.Hold)
		{
			Count(-1);
		}
	}

	private void Count(int increment)
	{
		var value = Config.Counter.State;

		if (value == null)
		{
			return;
		}

		var newValue = value.Value + increment;
		Config.Counter.SetValue(newValue);
		_notificationService.SendNotification(new Notification(Config.Notification, new object[] { newValue }));
	}
}
