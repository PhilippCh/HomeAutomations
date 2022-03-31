using Windows.Media.Control;

namespace HomeAutomations.Client.Media;

public record MediaPlayerPredicate
{
    public string ExecutableName { get; init; }
    public IEnumerable<string>? AllowedTitles { get; init; }

    public bool Matches(string executableName, string title) =>
        executableName.Contains(ExecutableName) && (AllowedTitles == null || AllowedTitles.Any(title.Contains));
}

public class MediaControllerService
{
    public async Task TogglePlayback(IEnumerable<MediaPlayerPredicate> allowedPlayers)
    {
        var sessionManager = await GlobalSystemMediaTransportControlsSessionManager.RequestAsync();
        var session = sessionManager.GetCurrentSession();
        var mediaProperties = await session.TryGetMediaPropertiesAsync();
        var sessions = sessionManager.GetSessions();
        var mediaProperties2 = sessions.Select(async s => await s.TryGetMediaPropertiesAsync())
            .Select(t => t.Result)
            .ToList();

        if (!allowedPlayers.Any(p => p.Matches(session.SourceAppUserModelId, mediaProperties.Title)))
        {
            return;
        }

        await session.TryTogglePlayPauseAsync();
    }
}