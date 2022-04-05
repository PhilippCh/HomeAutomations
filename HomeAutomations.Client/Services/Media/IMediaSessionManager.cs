namespace HomeAutomations.Client.Services.Media;

public interface IMediaSessionManager
{
	public Task<IEnumerable<MediaSession>> GetSessions();
}
