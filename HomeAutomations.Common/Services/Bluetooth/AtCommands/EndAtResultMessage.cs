using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands;

[AtResult]
public class EndAtResultMessage : IAtResult
{
	[JsonProperty("E", Required = Required.Always)]
	public int Id { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
		atCommandService.OnEndResultReceived(this);
	}
}
