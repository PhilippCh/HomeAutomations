namespace HomeAutomations.Models;

public record MobileAppNotificationData
{
	public const string Id = "mobile_app_notification_action";

	public string Action { get;init; }
}
