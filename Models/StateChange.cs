namespace HomeAutomations.Models;

public record StateChange
{
	public string? Old { get; init; }
	public string? New { get; init; }
}
