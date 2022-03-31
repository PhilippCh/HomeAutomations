using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Extensions;

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

	public static bool? AsBoolean(this EntityState? entityState)
	{
		if (bool.TryParse(entityState?.State, out var result))
		{
			return result;
		}

		return entityState?.State == "on";
	}
}