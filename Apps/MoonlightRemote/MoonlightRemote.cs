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

[Focus]
public class MoonlightRemote : BaseAutomation<MoonlightRemote, MoonlightRemoteConfig>
{
	private readonly Entities _entities;
	private readonly HttpClient _client = new();

	public MoonlightRemote(BaseAutomationDependencyAggregate<MoonlightRemote, MoonlightRemoteConfig> aggregate)
		: base(aggregate)
	{
		_entities = new Entities(Context);
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_start", StartStream);
		Context.RegisterServiceCallBack<MoonlightServiceData>("moonlight_stop", _ => StopStream());

		_entities.InputSelect.MoonlightSelectedHost.StateChanges()
			.Subscribe(s => UpdateAvailableGames(s.New?.State));

		Observable.Interval(TimeSpan.FromSeconds(20))
			.Subscribe(_ => UpdateStatus());
	}

	private async void UpdateStatus()
	{
		var response = await _client.GetAsync($"{Config.ApiBaseUrl}/status");
		var responseContent = await response.Content.ReadAsStringAsync();
		var status = JsonSerializer.Deserialize<MoonlightStatusResponse>(responseContent);

		Config.PidVar.CallService("set", new { value = status?.Pid ?? -1 });
	}

	private void UpdateAvailableGames(string? host)
	{
		var availableGames = (Config.Hosts
			                      .FirstOrDefault(h => h.Name == host)
			                      ?.Games
			                      .Select(g => g.DisplayName) ??
		                      new[] { "Keine Auswahl" }).ToList();

		availableGames.Insert(0, "Bitte wählen ...");

		_entities.InputSelect.MoonlightSelectedGame.SetOptions(
			new InputSelectSetOptionsParameters
			{
				Options = availableGames
			});
		_entities.InputSelect.MoonlightSelectedGame.SelectOption(availableGames.FirstOrDefault() ?? string.Empty);
	}

	private async void StartStream(MoonlightServiceData e)
	{
		var host = Config.Hosts.FirstOrDefault(h => h.Name == _entities.InputSelect.MoonlightSelectedHost.State);
		var game = host?.Games.FirstOrDefault(g => g.DisplayName == _entities.InputSelect.MoonlightSelectedGame.State);

		if (host == null || game == null)
		{
			Logger.Warning(
				"Could not find host {host} or game {game}",
				_entities.InputSelect.MoonlightSelectedHost.State,
				_entities.InputSelect.MoonlightSelectedGame.State);

			return;
		}

		var request = new { Host = host.Name, Game = game.Id };
		var response = await _client.PostAsJsonAsync($"{Config.ApiBaseUrl}/start", request);
	}

	private async void StopStream()
	{
		var response = await _client.PostAsync($"{Config.ApiBaseUrl}/stop", null);
	}
}
