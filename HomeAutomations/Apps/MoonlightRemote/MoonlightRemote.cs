using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
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
		Logger.Information("Connecting to {baseUrl}.", baseUrl);

		_apiClient = new MoonlightRemoteApiClient(baseUrl, new HttpClient());
		_browserModServices = Services.BrowserMod;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_start", StartStream);
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_stop", _ => StopStream());
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_reset_bluetooth", _ => ResetBluetooth());
		Context.Events.Filter<MobileAppNotificationData>(MobileAppNotificationData.EventType)
			.Where(e => e.Data?.Action == ShutdownAction)
			.Subscribe(_ => StopStream());
		Config.SelectedHost.StateChanges()
			.Subscribe(s => UpdateAvailableGames(s.New?.State));

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
			Config.CurrentHost.SetValue(!string.IsNullOrWhiteSpace(status?.Host) ? status!.Host : "None");
		}
		catch (TaskCanceledException ex)
		{
			Logger.Warning("Could not update status due to: {reason}", ex.Message);
		}
	}

	private void UpdateAvailableGames(string? hostDisplayName)
	{
		var host = GetHostByDisplayName(hostDisplayName);
		var availableGames = (host?.Games.Select(g => g.DisplayName) ?? new[] { "Keine Auswahl" }).ToList();

		availableGames.Insert(0, "Bitte wählen ...");

		Config.SelectedGame.SetOptions(
			new InputSelectSetOptionsParameters
			{
				Options = availableGames
			});
		Config.SelectedGame.SelectOption(availableGames.FirstOrDefault() ?? string.Empty);
	}

	private async void StartStream(MoonlightServiceData e)
	{
		var host = GetHostByDisplayName(Config.SelectedHost.State);
		var game = host?.GetGameByDisplayName(Config.SelectedGame.State);

		if (host == null || game == null)
		{
			Logger.Warning("Could not find host {host} or game {game}", Config.SelectedGame.State, Config.SelectedGame.State);

			return;
		}

		var request = new StartStreamRequest
		{
			Host = new StreamRequestHost { Host = host.Host, MacAddress = host.MacAddress },
			Game = game.Id,
			Features = new StreamRequestFeatures
			{
				Host = true,
				Moonlight = true,
				Harmony = true,
				Bluetooth = true
			}
		};
		await ExecuteWithResultToast(_apiClient.StartAsync(request));
	}

	private async void StopStream()
	{
		var hostAddress = Config.CurrentHost.State ?? Config.SelectedHost.State;
		var host = GetHost(hostAddress) ?? GetHostByDisplayName(Config.SelectedHost.State);

		if (host == null)
		{
			Logger.Warning("Could not find host {host} in list.", hostAddress);

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

		await ExecuteWithResultToast(_apiClient.StopAsync(request));
	}

	private async void ResetBluetooth()
	{
		await ExecuteWithResultToast(_apiClient.ResetBluetoothAsync());
	}

	private MoonlightHost? GetHost(string? host) => Config.Hosts.FirstOrDefault(h => h.Host == host);

	private MoonlightHost? GetHostByDisplayName(string? displayName) => Config.Hosts.FirstOrDefault(h => h.DisplayName == displayName);

	private async Task ExecuteWithResultToast(Task<TaskExecutionResult> task)
	{
		var response = await task;
		_browserModServices.Toast(response.Message);
	}
}
