namespace HomeAutomations.Extensions;

public static class BoolExtensions
{
	public static string ToOnOff(this bool input) => input ? "ON" : "OFF";
}
