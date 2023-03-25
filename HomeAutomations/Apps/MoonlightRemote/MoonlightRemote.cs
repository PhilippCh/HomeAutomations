using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.MoonlightRemote.Dtos;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Models.Generated.MoonlightRemoteApi;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.MoonlightRemote;

public class MoonlightRemote : BaseAutomation<MoonlightRemote, MoonlightRemoteConfig>
{
	private const string ShutdownAction = "MOONLIGHT_SHUTDOWN";

	private readonly IMoonlightRemoteApiClient _apiClient;
	private readonly BrowserModServices _browserModServices;

	public MoonlightRemote(BaseAutomationDependencyAggregate<MoonlightRemote, MoonlightRemoteConfig> aggregate)
		: base(aggregate)
	{
		var baseUrl = Config.ApiBaseUrl.CurrentValue;
		Logger.Information("Connecting to {BaseUrl}", baseUrl);

		_apiClient = new MoonlightRemoteApiClient(baseUrl, new HttpClient());
		_browserModServices = Services.BrowserMod;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_start", StartStream);
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_stop", _ => StopStream());
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_reset_bluetooth", _ => ResetBluetooth());

		Context.Events.Filter<MobileAppNotificationData>(MobileAppNotificationData.Id)
			.Where(e => e.Data?.Action == ShutdownAction)
			.Subscribe(_ => StopStream());

		Config.SelectedHost.StateChanges()
			.Select(s => s.New?.State)
			.StartWith(Config.SelectedHost.State)
			.Select(x => Observable.FromAsync(() => UpdateAvailableGamesAsync(x)))
			.Concat()
			.Subscribe(
				x =>
				{
					var gameNames = x?.Apps.Select(y => y.Name) ?? new[] { "Keine Auswahl" };
					Config.SelectedGame.SetOptions(new InputSelectSetOptionsParameters { Options = gameNames });
					Config.SelectedGame.SelectFirst();
				});

		Observable.Interval(TimeSpan.FromSeconds(20))
			.Subscribe(_ => UpdateStatus());

		await Task.CompletedTask;
	}

	private async void UpdateStatus()
	{
		try
		{
			var status = await _apiClient.StatusAsync();
			Config.Pid.SetValue(status?.Pid ?? -1);
			Config.CurrentHost.SetValue(!string.IsNullOrWhiteSpace(status?.Host) ? status.Host : "None");
		}
		catch (Exception ex)
		{
			Logger.Debug("Could not update streaming host status");
		}
	}

	private async Task<SunshineAppsResponseDto?> UpdateAvailableGamesAsync(string? hostDisplayName)
	{
		var host = GetHostByDisplayName(hostDisplayName);

		if (host is null)
		{
			Logger.Debug("Could not find host {DisplayName}", hostDisplayName);

			return null;
		}

		var client = GetSunshineHttpClient(Config.Sunshine.Username, Config.Sunshine.Password);

		try
		{
			return await client.GetFromJsonAsync<SunshineAppsResponseDto>(GetSunshineAppsUrl(host.Host));
		}
		catch (HttpRequestException)
		{
			return null;
		}
	}

	private string GetSunshineAppsUrl(string hostname) => $"https://{hostname}:{Config.Sunshine.Port}{Config.Sunshine.AppsPath}";

	private HttpClient GetSunshineHttpClient(string username, string password)
	{
		var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
		var handler = new HttpClientHandler();
		handler.ClientCertificateOptions = ClientCertificateOption.Manual;
		handler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;

		return new HttpClient(handler)
		{
			DefaultRequestHeaders = { Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray)) }
		};
	}

	private async void StartStream(MoonlightServiceData e)
	{
		var host = GetHostByDisplayName(Config.SelectedHost.State);
		var game = Config.SelectedGame.State;

		if (host == null || game == null)
		{
			Logger.Warning("Could not find host {Host} or game {Game}", Config.SelectedGame.State, Config.SelectedGame.State);

			return;
		}

		var request = new StartStreamRequest
		{
			Host = new StreamRequestHost { Host = host.Host, MacAddress = host.MacAddress },
			Game = game,
			Features = new StreamRequestFeatures
			{
				Host = true,
				Moonlight = true,
				Harmony = true,
				Bluetooth = true
			}
		};
		await ExecuteWithResultToastAsync(_apiClient.StartAsync(request));
	}

	private async void StopStream()
	{
		var hostAddress = Config.CurrentHost.State ?? Config.SelectedHost.State;
		var host = GetHost(hostAddress) ?? GetHostByDisplayName(Config.SelectedHost.State);

		if (host == null)
		{
			Logger.Warning("Could not find host {Host} in list", hostAddress);

			return;
		}

		var request = new StopStreamRequest
		{
			Host = new StreamRequestHost { Host = host.Host, MacAddress = host.MacAddress },
			Features = new StreamRequestFeatures
			{
				Harmony = Config.ShutdownHarmony.IsOn(),
				Host = Config.ShutdownHost.IsOn(),
				Bluetooth = true,
				Moonlight = true
			}
		};

		await ExecuteWithResultToastAsync(_apiClient.StopAsync(request));
	}

	private async void ResetBluetooth()
	{
		await ExecuteWithResultToastAsync(_apiClient.ResetBluetoothAsync());
	}

	private MoonlightHost? GetHost(string? host) => Config.Hosts.FirstOrDefault(h => h.Host == host);

	private MoonlightHost? GetHostByDisplayName(string? displayName) => Config.Hosts.FirstOrDefault(h => h.DisplayName == displayName);

	private async Task ExecuteWithResultToastAsync(Task<TaskExecutionResult> task)
	{
		var response = await task;
		//_browserModServices.Toast(response.Message);
	}
}
