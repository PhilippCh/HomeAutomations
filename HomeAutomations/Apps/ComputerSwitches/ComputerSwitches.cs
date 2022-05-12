using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated.MoonlightRemoteApi;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.ComputerSwitches;

[Focus]
public class ComputerSwitches : BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>
{
	private readonly IMqttEntityManager _entityManager;

	public ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var hostConfig in Config.Hosts)
		{
			await _entityManager.CreateAsync(hostConfig.EntityId, new EntityCreationOptions(Name: $"WOL switch for {hostConfig.Name}"));

			(await _entityManager.PrepareCommandSubscriptionAsync(hostConfig.EntityId))
				.Subscribe(async s => await OnSwitchStateChanged(hostConfig, s.AsBoolean()));
		}
	}

	private async Task OnSwitchStateChanged(HostConfig hostConfig, bool? isOn)
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
