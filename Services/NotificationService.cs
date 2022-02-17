using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using HomeAssistant.Automations.Constants;
using HomeAssistant.Automations.Models;
using NetDaemon.HassModel;
using Serilog;

namespace HomeAutomations.Services;

public class NotificationService
{
	public IObservable<string> NotificationActionFired => _notificationActionFired;

	private readonly IHaContext _context;
	private readonly ILogger _logger;
	private readonly HomeAssistantGenerated.Services _services;
	private readonly Subject<string> _notificationActionFired = new();

	public NotificationService(IHaContext context, ILogger logger)
	{
		_context = context;
		_services = new HomeAssistantGenerated.Services(context);
		context.Events
			.Where(e => e.EventType == EventTypes.MobileAppNotificationAction && e.DataElement.HasValue)
			.Select(e => e.DataElement!.Value.GetProperty("action").GetString()!)
			.Subscribe(OnNotificationActionFired);
		_logger = logger.ForContext<NotificationService>();
	}

	public void SendNotification(Notification notification)
	{
		_context.CallService(
			"notify", notification.Service, data: new
			{
				message = notification.Template,
				title = notification.Title,
				data = new
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
