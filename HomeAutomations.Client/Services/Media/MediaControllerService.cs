using System.Diagnostics;
using DeviceId;
using HomeAutomations.Client.Services.Media.NowPlaying;
using HomeAutomations.Client.Services.Media.VideoLan;
using HomeAutomations.Common.Models;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Client.Services.Media;

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
	private readonly MediaStatusConfig _config;
	private readonly HostService _hostService;
	private readonly IEnumerable<IMediaSessionManager> _sessionManagers;

	public MediaControllerService(
		NowPlayingMediaSessionManager nowPlayingMediaSessionManager,
		VlcRemoteApiService vlcRemoteApiService,
		HostService hostService,
		IOptionsMonitor<MediaStatusConfig> config)
	{
		_hostService = hostService;
		_sessionManagers = new IMediaSessionManager[] { nowPlayingMediaSessionManager, vlcRemoteApiService };
		_config = config.CurrentValue;
	}

	public async void TogglePlayback()
	{
		var sessions = await GetSessions();

		foreach (var session in sessions)
		{
			session.TogglePlayback();
		}
	}

	public async Task<MediaStatusMessage> GetStatus()
	{
		var sessions = await GetSessions();
		var deviceId = new DeviceIdBuilder()
			.AddMachineName()
			.AddMacAddress()
			.ToString();

		return new MediaStatusMessage
		{
			DeviceId = deviceId,
			BaseUrl = $"http://{_hostService.GetLocalIpAddress()}:{Constants.Port}",
			State = sessions.Any(s => s.State == MediaPlaybackState.Playing) ? MediaPlaybackState.Playing : MediaPlaybackState.NotPlaying
		};
	}

	private async Task<IEnumerable<MediaSession>> GetSessions() =>
		(await Task.WhenAll(_sessionManagers.Select(sm => sm.GetSessions())))
		.SelectMany(r => r)
		.Where(st => !string.IsNullOrWhiteSpace(st.AppId))
		.Where(x => _config.SupportedPlayers.Any(p => p.Matches(x.AppId, x.Title)));
}
