using NetDaemon.HassModel.Entities;

namespace HomeAssistant.Automations.Extensions
{
    public static class EntityStateExtensions
    {
        public static bool? AsBoolean(this EntityState entityState) => entityState.State != null && bool.Parse(entityState.State);
    }
}