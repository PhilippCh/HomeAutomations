using System.Collections.Generic;
using HomeAssistantGenerated;

namespace HomeAssistant.Automations.Services
{
    public class Notification
    {
        public string Title { get; set; }
        public string Template { get; set; }
        public string Tag { get; set; }
        public IEnumerable<NotificationAction> Actions { get; set; }
    }
    
    public class NotificationAction
    {
        public string Action { get; set; }
        public string Title { get; set; }
        public bool Destructive { get; set; }
    }

    public class NotificationService
    {
        private readonly HomeAssistantGenerated.Services _services;

        public NotificationService(HomeAssistantGenerated.Services services)
        {
            _services = services;
        }

        public void SendNotification(Notification notification)
        {
            _services.Notify.Notify(new NotifyNotifyParameters
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
    }
}