using System.Collections.Generic;

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
		{ "brightness_move_up", ButtonAction.BrightnessUp },
		{ "brightness_move_down", ButtonAction.BrightnessDown },
		{ "brightness_stop", ButtonAction.BrightnessStop },
	};

	public static ButtonAction Map(string? state) => _buttonActions.TryGetValue(state ?? string.Empty, out var action) ? action : ButtonAction.Undefined;

	public static bool IsPressedAction(string? state) =>
		Map(state) switch
		{
			ButtonAction.Undefined => false,
			ButtonAction.Single => true,
			ButtonAction.Double => true,
			ButtonAction.Triple => true,
			ButtonAction.Quadruple => true,
			ButtonAction.Hold => true,
			ButtonAction.Release => false,
			ButtonAction.Many => true,
			ButtonAction.On => true,
			ButtonAction.Off => false,
			ButtonAction.BrightnessUp => true,
			ButtonAction.BrightnessDown => true,
			ButtonAction.BrightnessStop => false,
			_ => false
		};
}
