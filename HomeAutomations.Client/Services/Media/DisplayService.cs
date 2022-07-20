using WindowsDisplayAPI.DisplayConfig;

namespace HomeAutomations.Client.Services.Media;

public class DisplayService
{
	public bool IsConnectedToMultipleDisplays() => PathInfo.GetActivePaths().Count(pi => pi.TargetsInfo[0].DisplayTarget.IsAvailable) > 1;
}
