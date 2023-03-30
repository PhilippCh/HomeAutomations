namespace HomeAutomations.Common.Models;

public enum Zone
{
	Unknown,
	Home,
	Enbw,
	Festplatz,
	DmArena
}

public class ZoneParser
{
	public static Zone Parse(string? action)
	{
		return action switch
		{
			"Home" => Zone.Home,
			"EnBW" => Zone.Enbw,
			"Messe Karlsruhe (Festplatz)" => Zone.Festplatz,
			"Messe Karlsruhe (dm Arena)" => Zone.DmArena,
			_ => Zone.Unknown
		};
	}
}
