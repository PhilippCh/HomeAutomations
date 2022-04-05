using HomeAutomations.Common.Models;

namespace HomeAutomations.Client.Services.Media;

public record MediaSession(string AppId, string Title, MediaPlaybackState State, Action TogglePlayback)
{
	public Action TogglePlayback { get; init; } = TogglePlayback;
}
