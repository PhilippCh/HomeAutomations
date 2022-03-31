using System;

namespace HomeAssistant.Automations.Extensions;

public static class MathExtensions
{
	public static int FloorToInt(double value) => (int) Math.Floor(value);
}
