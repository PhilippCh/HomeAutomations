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
	Many,
	On,
	Off
}

public static class WirelessSwitchActions
{
	public const string Single = "single";
	public const string Double = "double";
	public const string Triple = "triple";
	public const string Hold = "hold";
	public const string Release = "release";
	public const string On = "on";
	public const string Off = "off";

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
			"on" => ButtonAction.On,
			"off" => ButtonAction.Off,
			_ => ButtonAction.Undefined
		};
	}
}
