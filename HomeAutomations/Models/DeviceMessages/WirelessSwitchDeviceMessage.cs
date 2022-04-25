using System.Text.Json.Serialization;

namespace HomeAutomations.Models.DeviceMessages;

public enum ButtonAction
{
	Undefined,
	Single,
	Double,
	Triple,
	Quadruple,
	Hold,
	Release,
	Many
}

public static class WirelessSwitchActions
{
	public const string Single = "single";
	public const string Double = "double";
	public const string Triple = "triple";
	public const string Hold = "hold";
	public const string Release = "release";

	public static ButtonAction Map(string? action)
	{
		return action switch
		{
			"single" => ButtonAction.Single,
			"double" => ButtonAction.Double,
			"triple" => ButtonAction.Triple,
			"quadruple" => ButtonAction.Quadruple,
			"hold" => ButtonAction.Hold,
			"release" => ButtonAction.Release,
			"many" => ButtonAction.Many,
			_ => ButtonAction.Undefined
		};
	}
}
