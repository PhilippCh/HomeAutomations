namespace HomeAutomations.Services;

public interface IClockService
{
	DateTime Now => DateTime.Now;
}

public class ClockService : IClockService
{
	// This is a simple service that wraps DateTime.Now to make it easier to mock in tests.
}
