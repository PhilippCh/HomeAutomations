using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.ComputerSwitches;

public class ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate)
	: BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>(aggregate)
{
	private const string RunningState = "Running";

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		foreach (var hostConfig in Config.Hosts)
		{
			hostConfig.AvailabilitySensor
				.StateChangesWithCurrentState<SensorEntity, SensorAttributes>()
				.Subscribe(x => OnAvailabilitySensorChanged(hostConfig, x.New?.State));

			hostConfig.TriggerEntity
				.StateChanges()
				.Subscribe(x => OnSwitchStateChanged(hostConfig, x.New?.IsOn()));
		}

		return Task.CompletedTask;
	}

	private void OnAvailabilitySensorChanged(HostConfig hostConfig, string? state)
	{
		if (state.IsInvalidEntityState())
		{
			Logger.Warning("Invalid state {State} for computer availability sensor for {Name}", state, hostConfig.Name);

			return;
		}

		Logger.Information("{Host} Availability changed to {State}", hostConfig.Host, state);

		hostConfig.TriggerEntity.Switch(state!.Equals(RunningState, StringComparison.OrdinalIgnoreCase));
	}

	private void OnSwitchStateChanged(HostConfig hostConfig, bool? isOn)
	{
		if (isOn == null)
		{
			Logger.Warning("Invalid value for computer switch for {Name}", hostConfig.Name);

			return;
		}

		Logger.Information("{Switch} state changed to {State}", hostConfig.TriggerEntity.GetName(), isOn);

		if (isOn.Value)
		{
			BootMachine(hostConfig);
		}
		else if (!isOn.Value)
		{
			ShutdownMachine(hostConfig);
		}
	}

	private void BootMachine(HostConfig hostConfig)
	{
		Logger.Information("Starting host {HostName}", hostConfig.Name);

		var wakeOnLanService = new WakeOnLanServices(Context);
		wakeOnLanService.SendMagicPacket(hostConfig.MacAddress);
	}

	private void ShutdownMachine(HostConfig hostConfig)
	{
		Logger.Information("Stopping host {HostName}", hostConfig.Name);
		hostConfig.ShutdownButton.Press();
	}
}
