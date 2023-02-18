using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Shutters;

[Focus]
public class Shutters : BaseAutomation<Shutters, ShuttersConfig>
{
	public Shutters(BaseAutomationDependencyAggregate<Shutters, ShuttersConfig> aggregate)
		: base(aggregate)
	{
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		ObservableExtensions.IntervalSunset(Config.Latitude, Config.Longitude)
			.Delay(Config.CloseDelay)
			.Subscribe(_ => CloseAllShutters());

		Config.OpenSensorEntity.StateChanges().Subscribe(s => OnOpenButtonPressed(s.New?.State));

		return Task.CompletedTask;
	}

	private void OnOpenButtonPressed(string? state)
	{
		var action = WirelessSwitchActions.Map(state);

		if (action == ButtonAction.Double)
		{
			OpenAllShutters();
		}
	}

	private void OpenAllShutters()
	{
		Logger.Information("Opening shutters...");
		PerformForAllShuttersWithSafetyOverride(x => x.OpenCover());
	}

	private void CloseAllShutters()
	{
		Logger.Information("Closing shutters...");
		PerformForAllShuttersWithSafetyOverride(x => x.CloseCover());
	}

	private void PerformForAllShuttersWithSafetyOverride(Action<CoverEntity> action)
	{
		foreach (var shutter in Config.Shutters)
		{
			if (shutter.ForceOpenOverride.IsOn())
			{
				Logger.Debug("Cannot perform action on shutter {0} due to force open override being on", shutter.Entity.EntityId);

				continue;
			}

			action(shutter.Entity);
		}
	}
}
