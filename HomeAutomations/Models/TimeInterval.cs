namespace HomeAutomations.Models;

public record TimeInterval
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }

	public bool IsActiveFor(DateTime date, DateTime? startDate = null)
	{
		startDate = startDate ?? DateTime.Today;

		return startDate.Value.Add(Start) <= date && startDate.Value.Add(End) > date;
	}
}
