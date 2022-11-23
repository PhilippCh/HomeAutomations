using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;

[AtResult]
public class AckAtResult : IAtResult
{
	[JsonProperty("A", Required = Required.Always)]
	public int Id { get; set; }

	[JsonProperty("err")]
	public ErrorCode ErrorCode { get; set; }

	[JsonProperty("errMsg")]
	public string? ErrorMessage { get; set; }

	public void ProcessResult(AtCommandService atCommandService)
	{
		atCommandService.OnAckResultReceived(this);
	}
}
