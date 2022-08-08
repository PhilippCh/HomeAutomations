using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

public class CommandAtResult : IAtResult
{
	[JsonProperty("C", Required = Required.Always)]
	public int Id { get; set; }

	[JsonProperty("cmd", Required = Required.Always)]
	public string Command { get; set; }
}
