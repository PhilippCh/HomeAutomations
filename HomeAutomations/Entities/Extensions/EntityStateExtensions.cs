using System.Diagnostics.CodeAnalysis;
using HomeAutomations.Extensions;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Entities.Extensions;

public static class EntityStateExtensions
{
	public static int? AsInt(this EntityState? entityState)
	{
		if (int.TryParse(entityState?.State, out var result))
		{
			return result;
		}

		return null;
	}

	public static bool? AsBoolean(this EntityState? entityState) => entityState?.State.AsBoolean();

	public static bool IsValidButtonState([NotNullWhen(true)] this EntityState? entityState)
	{
		return string.Equals(entityState?.State, "on", StringComparison.OrdinalIgnoreCase) ||
		       string.Equals(entityState?.State, "off", StringComparison.OrdinalIgnoreCase);
	}
}
