using System.Collections.Generic;

namespace HomeAutomations.Apps.Vacuum
{
	public static class VacuumNotificationActions
	{
		public static IEnumerable<string> Actions => new[] { Start, NoStart };

		public const string Start = "VACUUM_START";
		public const string NoStart = "VACUUM_NO_START";
	}
}
