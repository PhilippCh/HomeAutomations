using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated.MoonlightRemoteApi;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.ComputerSwitches;

public class ComputerSwitches : BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>
{

	public ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var hostConfig in Config.Hosts)
		{
			hostConfig.Entity.StateChanges().Subscribe(s => OnWOLSwitchStateChanged(hostConfig, s.New?.IsOn()));
		}

		return Task.CompletedTask;
	}

	private async void OnWOLSwitchStateChanged(HostConfig hostConfig, bool? isOn)
	{
		if (!isOn.HasValue)
		{
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
}
