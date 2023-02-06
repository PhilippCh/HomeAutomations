namespace HomeAutomations.Models;

public record TimeInterval
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }

	public bool IsActiveFor(TimeSpan time) => Start <= time && time < End;
}
