using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.ComputerSwitches;

[Focus]
public class ComputerSwitches(
	BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate,
	WakeOnLanService wakeOnLanService) : BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>(aggregate)
{
	private const string RunningState = "Running";

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var hostConfig in Config.Hosts)
		{
			hostConfig.AvailabilitySensor
				.StateChangesWithCurrentState<SensorEntity, SensorAttributes>()
				.Subscribe(x => OnAvailabilitySensorChanged(hostConfig, x.New?.State));

			hostConfig.Entity
				.StateChanges()
				.SubscribeAsync(async x => await OnSwitchStateChangedAsync(hostConfig, x.New?.IsOn()));
		}

		return Task.CompletedTask;
	}

	private void OnAvailabilitySensorChanged(HostConfig hostConfig, string? state)
	{
		if (state == null)
		{
			Logger.Warning("Invalid state for computer availability sensor for {Name}", hostConfig.Name);

			return;
		}

		hostConfig.Entity.Switch(state.Equals(RunningState, StringComparison.OrdinalIgnoreCase));
	}

	private async Task OnSwitchStateChangedAsync(HostConfig hostConfig, bool? isOn)
	{
		if (isOn == null)
		{
			Logger.Warning("Invalid value for computer switch for {Name}", hostConfig.Name);

			return;
		}

		if (isOn.Value && !hostConfig.AvailabilitySensor.State!.Equals(RunningState, StringComparison.OrdinalIgnoreCase))
		{
			await BootMachineAsync(hostConfig);
		}
		else if (!isOn.Value)
		{
			ShutdownMachine(hostConfig);
		}
	}

	private async Task BootMachineAsync(HostConfig hostConfig)
	{
		Logger.Information("Starting host {HostName}", hostConfig.Name);

		await wakeOnLanService.WaitUntilAvailableAsync(hostConfig.Host, hostConfig.MacAddress);
	}

	private void ShutdownMachine(HostConfig hostConfig)
	{
		Logger.Information("Stopping host {HostName}", hostConfig.Name);
		hostConfig.ShutdownButton.Press();
	}
}
