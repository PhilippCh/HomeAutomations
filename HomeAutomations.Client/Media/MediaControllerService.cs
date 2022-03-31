using NPSMLib;

namespace HomeAutomations.Client.Media;

public record MediaPlayerPredicate
{
	public string ExecutableName { get; init; }
	public IEnumerable<string>? AllowedTitles { get; init; }

	public bool Matches(string executableName, string title) =>
		executableName.Contains(ExecutableName, StringComparison.InvariantCultureIgnoreCase) &&
		(AllowedTitles == null || AllowedTitles.Any(t => title.Contains(t, StringComparison.InvariantCultureIgnoreCase)));
}

public class MediaControllerService
{
	private readonly NowPlayingMediaSessionManager _nowPlayingMediaSessionManager;

	public MediaControllerService(NowPlayingMediaSessionManager nowPlayingMediaSessionManager)
	{
		_nowPlayingMediaSessionManager = nowPlayingMediaSessionManager;
	}

	public void TogglePlayback(IEnumerable<MediaPlayerPredicate> allowedPlayers)
	{
		var sessions = _nowPlayingMediaSessionManager.GetSessions()
			.Select(s => (Session: s, MediaInfo: s.ActivateMediaPlaybackDataSource().GetMediaObjectInfo()))
			.Where(st => !string.IsNullOrWhiteSpace(st.Session.SourceAppId))
			.Where(x => allowedPlayers.Any(p => p.Matches(x.Session.SourceAppId, x.MediaInfo.Title)))
			.Select(x => x.Session);

		foreach (var session in sessions)
		{
			session.ActivateMediaPlaybackDataSource().SendMediaPlaybackCommand(MediaPlaybackCommands.PlayPauseToggle);
		}
	}

	public MediaStatus GetStatus()
	{
		var sessions = _nowPlayingMediaSessionManager.GetSessions();

		return new MediaStatus
		{
			State = sessions.Any(s => s.ActivateMediaPlaybackDataSource().GetMediaPlaybackInfo().PlaybackState == MediaPlaybackState.Playing)
				? MediaPlaybackState.Playing
				: MediaPlaybackState.Unknown
		};
	}
}
