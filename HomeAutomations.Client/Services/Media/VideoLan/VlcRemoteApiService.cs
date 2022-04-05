using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;
using HomeAutomations.Common.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Client.Services.Media.VideoLan;

public class VlcRemoteApiService : IMediaSessionManager
{
	private VlcConfig _config;

	public VlcRemoteApiService(IOptionsMonitor<VlcConfig> config)
	{
		_config = config.CurrentValue;
	}

	public async Task<IEnumerable<MediaSession>> GetSessions()
	{
		var client = CreateApiClient();
		var state = MediaPlaybackState.NotPlaying;

		try
		{
			using var cts = new CancellationTokenSource(new TimeSpan(0, 0, 2));
			var response = await client.GetStringAsync(GetApiUrl("status.xml"), cts.Token);
			var document = XDocument.Parse(response);
			state = document.Root?.Element("state")?.Value switch
			{
				"playing" => MediaPlaybackState.Playing,
				_ => MediaPlaybackState.NotPlaying
			};
		}
		catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException)
		{
			// Do nothing.
		}

		return new[]
		{
			new MediaSession("vlc", "", state, TogglePlayback)
		};
	}

	private string GetApiUrl(string method) => Path.Combine(_config.BaseUrl, "requests", method).Replace("\\", "/");

	private async void TogglePlayback()
	{
		var client = CreateApiClient();
		await client.GetAsync(GetApiUrl("status.xml?command=pl_pause")); // Pause appears to be toggleable.
	}

	private HttpClient CreateApiClient()
	{
		var byteArray = Encoding.ASCII.GetBytes($":{_config.Password}");
		var client = new HttpClient();
		client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

		return client;
	}
}
