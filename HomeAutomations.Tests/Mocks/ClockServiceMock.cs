using System;
using HomeAutomations.Services;

namespace HomeAutomations.Tests.Mocks;

public class ClockServiceMock : IClockService
{
	public DateTime Now { get; set; } = DateTime.MinValue;
}
