using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text.Json.Serialization;
using HomeAssistant.Automations.Constants;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Common;
using Serilog;

namespace HomeAssistant.Automations.Services;

public class Notification
{
	public string Title { get; set; }
	public string Template { get; set; }
	public string Tag { get; set; }
	public IEnumerable<NotificationAction> Actions { get; set; }
}

public class NotificationAction
{
	[JsonPropertyName("action")]
	public string Action { get; set; }

	[JsonPropertyName("title")]
	public string Title { get; set; }

	[JsonPropertyName("destructive")]
	public bool Destructive { get; set; }
}

public class NotificationService
{
	public IObservable<string> NotificationActionFired => _notificationActionFired;

	private readonly HomeAssistantGenerated.Services _services;
	private readonly ILogger _logger;
	private readonly Subject<string> _notificationActionFired = new();

	public NotificationService(IHaContext context, ILogger logger)
	{
		_services = new HomeAssistantGenerated.Services(context);
		context.Events
			.Where(e => e.EventType == EventTypes.MobileAppNotificationAction && e.DataElement.HasValue)
			.Select(e => e.DataElement!.Value.GetProperty("action").GetString()!)
			.Subscribe(OnNotificationActionFired);
		_logger = logger.ForContext<NotificationService>();
	}

	public void SendNotification(Notification notification)
	{
		_logger.Information("Notifying of pending vacuum run");
		_services.Notify.MobileAppIphonePhilipp(
			new NotifyMobileAppIphonePhilippParameters
			{
				Message = notification.Template,
				Title = notification.Title,
				Data = new
				{
					tag = notification.Tag,
					actions = notification.Actions
				}
			});
	}

	private void OnNotificationActionFired(string action)
	{
		_logger.Debug("Notification action received: {action}", action);
		_notificationActionFired.OnNext(action);
	}
}
