using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Extensions
{
    public static class EntityStateExtensions
    {
        public static bool? AsBoolean(this EntityState? entityState)
        {
	        if (bool.TryParse(entityState?.State, out var result))
	        {
		        return result;
	        }

	        return entityState?.State == "on";
        }
    }
}
