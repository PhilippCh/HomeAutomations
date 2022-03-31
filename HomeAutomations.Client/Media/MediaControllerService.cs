﻿using NPSMLib;

namespace HomeAutomations.Client.Media;

public record MediaPlayerPredicate
{
	public string ExecutableName { get; init; }
	public IEnumerable<string>? AllowedTitles { get; init; }

	public bool Matches(string executableName, string title) => executableName.Contains(ExecutableName) && (AllowedTitles == null || AllowedTitles.Any(title.Contains));
}

public class MediaControllerService
{
	private readonly NowPlayingMediaSessionManager _nowPlayingMediaSessionManager;

	public MediaControllerService(NowPlayingMediaSessionManager nowPlayingMediaSessionManager)
	{
		_nowPlayingMediaSessionManager = nowPlayingMediaSessionManager;
	}

	public async Task TogglePlayback(IEnumerable<MediaPlayerPredicate> allowedPlayers)
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
}
