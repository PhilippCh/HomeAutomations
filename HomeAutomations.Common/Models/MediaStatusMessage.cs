namespace HomeAutomations.Common.Models;

public enum MediaPlaybackState
{
	NotPlaying,
	Playing
}

public record MediaStatusMessage
{
	public string DeviceId { get; init; }
	public string? BaseUrl { get; init; }
	public MediaPlaybackState State { get; init; }
}
