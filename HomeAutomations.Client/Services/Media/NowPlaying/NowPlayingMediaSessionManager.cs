using NPSMLib;
using MediaPlaybackState = HomeAutomations.Common.Models.MediaPlaybackState;

namespace HomeAutomations.Client.Services.Media.NowPlaying;

public class NowPlayingMediaSessionManager : IMediaSessionManager
{
	private NowPlayingSessionManager _sessionManager;

	public NowPlayingMediaSessionManager()
	{
		NowPlayingSessionManagerService.Started += NpsmService_Started;
		OnNpsmServiceStarted();
	}

	public Task<IEnumerable<MediaSession>> GetSessions() => Task.FromResult(_sessionManager.GetSessions().Select(GetPlaybackState));

	private MediaSession GetPlaybackState(NowPlayingSession sourceSession)
	{
		var mediaInfo = sourceSession.ActivateMediaPlaybackDataSource().GetMediaObjectInfo();
		var state = sourceSession.ActivateMediaPlaybackDataSource().GetMediaPlaybackInfo().PlaybackState switch
		{
			NPSMLib.MediaPlaybackState.Playing => MediaPlaybackState.Playing,
			_ => MediaPlaybackState.NotPlaying
		};

		return new MediaSession(
			sourceSession.SourceAppId, mediaInfo.Title, state,
			() => sourceSession.ActivateMediaPlaybackDataSource().SendMediaPlaybackCommand(MediaPlaybackCommands.PlayPauseToggle));
	}

	private void NpsmService_Started(object sender, EventArgs e)
	{
		OnNpsmServiceStarted();
	}

	private void OnNpsmServiceStarted()
	{
		//Example: explorer.exe crashes, the NPSMLib still holds the "link"
		//THEN explorer.exe restarts and NPSM restarts too, reloading all NPSM sessions

		//Now recreate NPSessionManager.
		_sessionManager = new NowPlayingSessionManager();
	}
}
