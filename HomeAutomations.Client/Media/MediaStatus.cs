using NPSMLib;

namespace HomeAutomations.Client.Media;

public record MediaStatus
{
	public MediaPlaybackState State { get; init; }
}
