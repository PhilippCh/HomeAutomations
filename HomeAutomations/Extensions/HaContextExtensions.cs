using System.Collections.Generic;
using System.Linq;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Extensions;

public static class HaContextExtensions
{
	public static IEnumerable<Entity> GetAllEntities(this IHaContext context, string? type = default) =>
		type == default
			? context.GetAllEntities()
			: context.GetAllEntities().Where(e => e.EntityId.StartsWith($"{type}."));
}
