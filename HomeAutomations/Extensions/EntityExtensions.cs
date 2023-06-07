using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Extensions;

public static class EntityExtensions
{
	public static string GetName(this Entity entity) => entity.EntityId[(entity.EntityId.IndexOf('.') + 1)..];
}

public static class PersonEntityExtensions
{
	public static bool IsGpsPositionAccurate(this PersonAttributes attributes, double threshold)
	{
		var accuracy = attributes.GpsAccuracy ?? double.MaxValue;

		return accuracy < threshold;
	}
}
