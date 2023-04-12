using System.Collections.Generic;
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
	Off,
	BrightnessUp,
	BrightnessDown,
	BrightnessStop,
}

public static class WirelessSwitchActions
{
	private static readonly IReadOnlyDictionary<string, ButtonAction> _buttonActions = new Dictionary<string, ButtonAction>
	{
		{ "single", ButtonAction.Single },
		{ "double", ButtonAction.Double },
		{ "triple", ButtonAction.Triple },
		{ "hold", ButtonAction.Hold },
		{ "release", ButtonAction.Release },
		{ "on", ButtonAction.On },
		{ "off", ButtonAction.Off },
		{ "brightness_up", ButtonAction.BrightnessUp },
		{ "brightness_down", ButtonAction.BrightnessDown },
		{ "brightness_stop", ButtonAction.BrightnessStop },
	};

	public static ButtonAction Map(string? value) => _buttonActions.TryGetValue(value ?? string.Empty, out var action) ? action : ButtonAction.Undefined;
}
