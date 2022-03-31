using NPSMLib;

namespace HomeAutomations.Client.Media;

public class NowPlayingMediaSessionManager
{
	private NowPlayingSessionManager _sessionManager;

	public NowPlayingMediaSessionManager()
	{
		NowPlayingSessionManagerService.Started += NpsmService_Started;
		OnNpsmServiceStarted();
	}

	public IEnumerable<NowPlayingSession> GetSessions() => _sessionManager.GetSessions();

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
