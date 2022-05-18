using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Models.Generated.MoonlightRemoteApi;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.ComputerSwitches;

[Focus]
public class ComputerSwitches : BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>
{
	private bool _ignoreLastStateChange;
	private readonly HttpClient _httpClient;

	public ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate, HttpClient httpClient)
		: base(aggregate)
	{
		_httpClient = httpClient;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		ObservableExtensions.Interval(Config.AvailabilityCheck.Interval, true)
			.SelectMany(_ => Config.Hosts)
			.SelectMany(h => Observable.FromAsync(async () => await UpdateWolSwitchStatus(h)))
			.Subscribe();

		foreach (var hostConfig in Config.Hosts)
		{
			hostConfig.Entity.StateChanges().Subscribe(s => OnWolSwitchStateChanged(hostConfig, s.New?.IsOn()));
		}

		return Task.CompletedTask;
	}

	private async void OnWolSwitchStateChanged(HostConfig hostConfig, bool? isOn)
	{
		if (isOn == null)
		{
			Logger.Warning("Invalid value for WOL switch for {Name}", hostConfig.Name);

			return;
		}

		if (_ignoreLastStateChange)
		{
			_ignoreLastStateChange = false;

			return;
		}

		if (isOn.Value)
		{
			await BootMachine(hostConfig);
		}
		else
		{
			await ShutdownMachine(hostConfig);
		}
	}

	private async Task BootMachine(HostConfig hostConfig)
	{
		var client = new MoonlightRemoteApiClient(Config.ApiBaseUrl.CurrentValue, new HttpClient());

		Logger.Information("Starting host {HostName}", hostConfig.Name);

		await client.StartAsync(
			new StartStreamRequest
			{
				Host = new StreamRequestHost
				{
					Host = hostConfig.Host,
					MacAddress = hostConfig.MacAddress
				},
				Features = new StreamRequestFeatures
				{
					Bluetooth = false,
					Harmony = false,
					Moonlight = false,
					Host = true
				}
			});
	}

	private async Task ShutdownMachine(HostConfig hostConfig)
	{
		var client = new MoonlightRemoteApiClient(Config.ApiBaseUrl.CurrentValue, new HttpClient());

		Logger.Information("Stopping host {HostName}", hostConfig.Name);

		await client.StopAsync(
			new StopStreamRequest
			{
				Host = new StreamRequestHost
				{
					Host = hostConfig.Host,
					MacAddress = hostConfig.MacAddress
				},
				Features = new StreamRequestFeatures
				{
					Bluetooth = false,
					Harmony = false,
					Moonlight = false,
					Host = true
				}
			});
	}

	private async Task UpdateWolSwitchStatus(HostConfig host)
	{
		var isAvailable = await GetHostAvailability(host);

		if (isAvailable == host.Entity.IsOn())
		{
			return;
		}

		// Prevent triggering a boot/shutdown from internal state changes.
		_ignoreLastStateChange = true;

		if (isAvailable)
		{
			host.Entity.TurnOn();
		}
		else
		{
			host.Entity.TurnOff();
		}
	}

	private async Task<bool> GetHostAvailability(HostConfig hostConfig)
	{
		try
		{
			using var cts = new CancellationTokenSource(Config.AvailabilityCheck.Timeout);
			var result = await _httpClient.GetAsync(GetHostApiUrl(hostConfig.Host), cts.Token);

			return result.StatusCode == HttpStatusCode.NotFound;
		}
		catch (Exception ex)
		{
			if (ex is TaskCanceledException or HttpRequestException)
			{
				return false;
			}

			Logger.Warning("Uncaught exception {Message}", ex.Message);

			return false;
		}
	}

	private string GetHostApiUrl(string host, string? endpoint = default) => $"http://{host}:{Config.AvailabilityCheck.Port}/api{endpoint}";
}
