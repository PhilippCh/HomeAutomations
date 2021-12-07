using HomeAssistant.Automations.Services;

namespace HomeAssistant.Automations.Apps.Vacuum
{
    public class VacuumConfig
    {
        public string CleaningSchedule { get; set; }
        public int ReminderEveryMinutes { get; set; }
        public Notification Reminder { get; set; }
    }
}