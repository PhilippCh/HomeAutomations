namespace HomeAutomations.Common.Models;

public enum MediaPlaybackState
{
	Unknown,
	NotPlaying,
	Playing
}

public record MediaStatusMessage
{
	public string DeviceId { get; init; }
	public string? BaseUrl { get; init; }
	public MediaPlaybackState State { get; init; }
	public MediaPlaybackState LastState { get; init; }
}
