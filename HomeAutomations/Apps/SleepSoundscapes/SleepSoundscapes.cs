using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using Simple.MPD;
using Simple.MPD.Networking;

namespace HomeAutomations.Apps.SleepSoundscapes;

public class SleepSoundscapes : BaseAutomation<SleepSoundscapes, SleepSoundscapesConfig>
{
	public SleepSoundscapes(BaseAutomationDependencyAggregate<SleepSoundscapes, SleepSoundscapesConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		/*await RemoveExistingPlaylistsAsync();

		foreach (var soundscape in Config.Soundscapes)
		{
			await CreatePlaylistAsync(soundscape);
		}

		Config.Sensor.StateChanges()
			.Select(s => Observable.FromAsync(() => OnButtonPressedAsync(s.New?.State)))
			.Concat()
			.Subscribe();*/
	}

	private async Task OnButtonPressedAsync(string? state)
	{
		var action = WirelessSwitchActions.Map(state);

		if (action == ButtonAction.Undefined)
		{
			return;
		}

		var client = await CreateMpdClientAsync();
		var status = await client.GetStatusAsync();

		if (status.State == PlaybackState.Play)
		{
			Stop(client);

			return;
		}

		var soundscape = Config.Soundscapes.FirstOrDefault(s => s.ButtonAction == action);

		if (soundscape == null)
		{
			Logger.Warning("Could not find soundscape for button action {Action}", action.ToString());

			return;
		}

		Play(client, soundscape.Id);
	}

	private async Task CreatePlaylistAsync(SoundscapeConfig soundscape)
	{
		var client = await CreateMpdClientAsync();
		await client.QueueClear();

		Logger.Information("Creating playlist {Id}", soundscape.Id);

		var songFiles = (await client.LsInfo(soundscape.Directory))
			.Where(si => !string.IsNullOrWhiteSpace(si.File));

		foreach (var songInfo in songFiles)
		{
			await client.QueueAdd(songInfo.File);
		}

		await client.SaveQueue(soundscape.Id);
	}

	private async Task RemoveExistingPlaylistsAsync()
	{
		var client = await CreateMpdClientAsync();
		var playlists = Config.Soundscapes.Select(s => s.Id).ToList();
		var removePlaylists = (await client.ListPlaylists())
			.Where(pl => playlists.Contains(pl.PlayList))
			.ToList();

		Logger.Information("Removing {Count} old playlists", removePlaylists.Count);

		foreach (var playlist in removePlaylists)
		{
			await client.RemovePlaylist(playlist.PlayList);
		}
	}

	private async void Play(MPD client, string playlistId)
	{
		var playlist = await client.ListPlaylistInfo(playlistId);
		await client.QueueClear();

		foreach (var song in playlist.Songs)
		{
			await client.QueueAdd(song.File);
		}

		Logger.Information("Playing soundscape {Id}", playlistId);
		await client.PlayAsync();
	}

	private async void Stop(MPD client)
	{
		Logger.Information("Stopping soundscape");
		await client.StopAsync();
		await client.QueueClear();
	}

	private async Task<MPD> CreateMpdClientAsync()
	{
		var client = new MPD(new TcpConnection(Config.MpdServerHost));
		await client.SetCrossfadeAsync(Config.CrossfadeSeconds);
		await client.SetRepeatAsync(true);

		return client;
	}
}
