using HomeAssistant.Automations.Models;
using JetBrains.Annotations;

namespace HomeAssistant.Automations.Apps.Vacuum
{
	[UsedImplicitly]
	public class VacuumNotificationConfig
	{
		public Notification Reminder { get; set; }
		public Notification CleanBedroom { get; set; }
		public Notification EmptyBin { get; set; }
	}

    public class VacuumConfig : Config
    {
    public string Entity {get;set;}
	    public string CleaningSchedule { get; set; }
        public int ReminderIntervalMinutes { get; set; }
        public VacuumNotificationConfig Notifications { get; set; }
    }
}
