using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.MoonlightRemote;

public class MoonlightRemote : BaseAutomation<MoonlightRemote, MoonlightRemoteConfig>
{
	private const string ShutdownAction = "MOONLIGHT_SHUTDOWN";

	private readonly HttpClient _client = new();

	public MoonlightRemote(BaseAutomationDependencyAggregate<MoonlightRemote, MoonlightRemoteConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_start", StartStream);
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_stop", _ => StopStream());
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
		var response = await _client.GetAsync($"{Config.ApiBaseUrl}/status");
		var responseContent = await response.Content.ReadAsStringAsync();
		var status = JsonSerializer.Deserialize<MoonlightStatusResponse>(responseContent);

		Config.Pid.CallService("set", new { value = status?.Pid ?? -1 });
	}

	private void UpdateAvailableGames(string? host)
	{
		var availableGames = (Config.Hosts
			                      .FirstOrDefault(h => h.Name == host)
			                      ?.Games
			                      .Select(g => g.DisplayName) ??
		                      new[] { "Keine Auswahl" }).ToList();

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
		var host = Config.Hosts.FirstOrDefault(h => h.Name == Config.SelectedHost.State);
		var game = host?.Games.FirstOrDefault(g => g.DisplayName == Config.SelectedGame.State);

		if (host == null || game == null)
		{
			Logger.Warning("Could not find host {host} or game {game}", Config.SelectedGame.State, Config.SelectedGame.State);

			return;
		}

		var response = await _client.PostAsJsonAsync($"{Config.ApiBaseUrl}/start", new { Host = host.Name, Game = game.Id });
	}

	private async void StopStream()
	{
		var result = await _client.PostAsync($"{Config.ApiBaseUrl}/stop", null);
	}
}
