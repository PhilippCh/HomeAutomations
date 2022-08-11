using Newtonsoft.Json;

namespace HomeAutomations.Common.Services.Bluetooth.AtCommands.Events;

public abstract class AtEvent<T> : IAtResult
{
	[JsonProperty("eventId", Required = Required.Always)]
	public EventCode EventCode { get; set; }

	[JsonProperty("connectionId", Required = Required.Always)]
	public string ConnectionId { get; set; }

	public T? Data { get; set; }

	public abstract void ProcessResult(AtCommandService atCommandService);
}
