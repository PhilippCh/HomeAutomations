using System.Text.Json.Serialization;

namespace HomeAutomations.Models.DeviceMessages;

/// <summary>
/// Aqara button device message.
/// This devices reports the following properties:
///   - Action
/// </summary>
public class ButtonDeviceMessage : ZigbeeDeviceMessage
{
	public const ButtonAction SpecialActionBegin = ButtonAction.Hold;

	public ButtonAction Action =>
		ActionName switch
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

	[JsonPropertyName("action")]
	public string ActionName { get; init; }
}
