namespace HomeAutomations.Common.Models;

public enum Zone
{
	Unknown,
	Home,
	WorkPup,
	WorkFant
}

public class ZoneParser
{
	public static Zone Parse(string? action)
	{
		return action switch
		{
			"home" => Zone.Home,
			"Work Pup" => Zone.WorkPup,
			"Work Fant" => Zone.WorkFant,
			_ => Zone.Unknown
		};
	}
}
