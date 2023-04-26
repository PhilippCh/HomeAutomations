using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.ComputerSwitches;

public class ComputerSwitches : BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>
{
	private bool _ignoreLastStateChange;
	private readonly HttpClient _httpClient;
	private readonly WakeOnLanService _wakeOnLanService;

	public ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate, HttpClient httpClient, WakeOnLanService wakeOnLanService)
		: base(aggregate)
	{
		_httpClient = httpClient;
		_wakeOnLanService = wakeOnLanService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		ObservableExtensions.Interval(Config.AvailabilityCheck.Interval, true)
			.SelectMany(_ => Config.Hosts)
			.SelectMany(h => Observable.FromAsync(async () => await UpdateWolSwitchStatusAsync(h)))
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
			await BootMachineAsync(hostConfig);
		}
		else
		{
			await ShutdownMachineAsync(hostConfig);
		}
	}

	private async Task BootMachineAsync(HostConfig hostConfig)
	{
		Logger.Information("Starting host {HostName}", hostConfig.Name);

		await _wakeOnLanService.WaitUntilAvailableAsync(hostConfig.Host, hostConfig.MacAddress);
	}

	private async Task ShutdownMachineAsync(HostConfig hostConfig)
	{
		Logger.Information("Stopping host {HostName}", hostConfig.Name);
		await _wakeOnLanService.ShutdownAsync(hostConfig.Host);
	}

	private async Task UpdateWolSwitchStatusAsync(HostConfig host)
	{
		var isAvailable = await GetHostAvailabilityAsync(host);

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

	private async Task<bool> GetHostAvailabilityAsync(HostConfig hostConfig)
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
