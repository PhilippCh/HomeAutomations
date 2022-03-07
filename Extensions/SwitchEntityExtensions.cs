using HomeAutomations.Models.Generated;

namespace HomeAutomations.Extensions
{
    public static class SwitchEntityExtensions
    {
        public static void SetState(this SwitchEntity entity, bool state)
        {
	        if (state)
	        {
		        entity.TurnOn();
	        }
	        else
	        {
		        entity.TurnOff();
	        }
        }
    }
}
