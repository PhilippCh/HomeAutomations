namespace HomeAutomations.Models;

public record TimeInterval
{
	public TimeSpan Start { get; init; }
	public TimeSpan End { get; init; }

	public bool IsActiveFor(TimeSpan time)
	{
		if (Start <= End)
		{
			// start and stop times are in the same day
			if (time >= Start && time < End)
			{
				return true;
			}
		}
		else
		{
			// start and stop times are in different days
			if (time >= Start || time < End)
			{
				return true;
			}
		}

		return false;
	}
}
