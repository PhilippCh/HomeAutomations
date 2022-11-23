using HomeAutomations.Common.Services.Bluetooth.Commands.Messages.Results;
using Newtonsoft.Json;
using Serilog;

namespace HomeAutomations.Common.Services.Bluetooth.Commands.Events;

public abstract class AtEvent<T> : IAtResult
{
	[JsonProperty("eventId", Required = Required.Always)]
	public EventCode EventCode { get; set; }

	[JsonProperty("connectionId", Required = Required.Always)]
	public string? ConnectionId { get; set; }

	public T? Data { get; set; }

	protected ILogger Logger { get; }

	public AtEvent()
	{
		// ReSharper disable once ContextualLoggerProblem
		Logger = Log.Logger.ForContext<T>();
	}

	public abstract void ProcessResult(AtCommandService atCommandService);
}
