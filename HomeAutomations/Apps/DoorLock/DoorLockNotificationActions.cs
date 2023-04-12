using System.Collections.Generic;

namespace HomeAutomations.Apps.DoorLock;

public static class DoorLockNotificationActions
{
	public static IEnumerable<string> Actions => new[] { KeepActive };

	public const string KeepActive = "DOOR_LOCK_KEEP_ACTIVE";
}
