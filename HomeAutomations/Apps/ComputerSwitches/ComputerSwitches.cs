using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.ComputerSwitches;

public class ComputerSwitches(BaseAutomationDependencyAggregate<ComputerSwitches, ComputerSwitchesConfig> aggregate)
	: BaseAutomation<ComputerSwitches, ComputerSwitchesConfig>(aggregate)
{
	private const string ServicePrefix = "computer_switches";

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<ComputerSwitchesServiceData>($"{ServicePrefix}_boot", x => PerformWithHostConfig(x.Id, BootMachine));
		Context.RegisterServiceCallBack<ComputerSwitchesServiceData>($"{ServicePrefix}_shutdown", x => PerformWithHostConfig(x.Id, ShutdownMachine));

		return Task.CompletedTask;
	}

	private void BootMachine(HostConfig hostConfig)
	{
		Logger.Information("Starting host {Id}", hostConfig.Id);

		if (hostConfig.MacAddress == null)
		{
			Logger.Warning("Mac address for {Id} is null", hostConfig.Id);

			return;
		}

		var wakeOnLanService = new WakeOnLanServices(Context);
		wakeOnLanService.SendMagicPacket(hostConfig.MacAddress);
	}

	private void ShutdownMachine(HostConfig hostConfig)
	{
		Logger.Information("Stopping host {Id}", hostConfig.Id);
		hostConfig.ShutdownButton.Press();
	}

	private void PerformWithHostConfig(string id, Action<HostConfig> action)
	{
		var hostConfig = Config.Hosts?.FirstOrDefault(x => x.Id == id);

		if (hostConfig == null)
		{
			Logger.Warning("Could not find host config for id {Id}", id);

			return;
		}

		action(hostConfig);
	}
}
