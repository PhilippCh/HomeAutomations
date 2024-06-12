using System.Reflection;
using System.Text.Json;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Tests.Extensions;

public static class EntityStateExtensions
{
	public static EntityState WithAttributes(this EntityState entityState, object attributes)
	{
		var copy = entityState with { };
		entityState.GetType().GetProperty("AttributesJson")!.SetValue(copy, attributes.AsJsonElement());
		return copy;
	}
}
