using System.Reactive.Subjects;
using HomeAutomations.Models;

namespace HomeAutomations.Services;

public class NotificationService
{
	[Obsolete("Remove and use context.Events directly for different event types.")]
	public IObservable<string> NotificationActionFired => _notificationActionFired;

	private readonly IHaContext _context;
	private readonly ILogger _logger;
	private readonly Models.Generated.Services _services;
	private readonly Subject<string> _notificationActionFired = new();

	public NotificationService(IHaContext context, ILogger logger)
	{
		_context = context;
		_services = new Models.Generated.Services(context);
		context.Events
			.Where(e => e.EventType == MobileAppNotificationData.Id && e.DataElement.HasValue)
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
					actions = notification.Actions,
					image = notification.Image,
					sticky = notification.Sticky,
					url = notification.Url
				}
			});
	}

	private void OnNotificationActionFired(string action)
	{
		_logger.Debug("Notification action received: {action}", action);
		_notificationActionFired.OnNext(action);
	}
}
