using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

[AtResult]
public class CommandAtResult : IAtResult
{
	[JsonProperty("C", Required = Required.Always)]
	public int Id { get; set; }

	[JsonProperty("cmd", Required = Required.Always)]
	public string Command { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
		atCommandService.OnCommandResultReceived(this);
	}
}
