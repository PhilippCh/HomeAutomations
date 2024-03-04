using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Shutters;

public class Shutters : BaseAutomation<Shutters, ShuttersConfig>
{
	private readonly Dictionary<ShutterConfig, IDisposable> _retryCloseShutterObservers = new();

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

		foreach (var shutter in Config.Shutters)
		{
			if (!shutter.ForceOpenOverride.IsOn())
			{
				shutter.Entity.OpenCover();
			}
		}
	}

	private void CloseAllShutters()
	{
		Logger.Information("Closing shutters...");

		foreach (var shutter in Config.Shutters)
		{
			if (shutter.ForceOpenOverride.IsOn())
			{
				RetryCloseShutter(shutter);

				continue;
			}

			CloseShutter(shutter);
		}
	}

	private void CloseShutter(ShutterConfig shutter)
	{
		shutter.Entity.CloseCover();
		TryDisposeRetryCloseObserver(shutter);
	}

	private void RetryCloseShutter(ShutterConfig shutter)
	{
		Logger.Information("Could not close {Shutter}, retrying when force open is false", shutter.Entity.EntityId);

		TryDisposeRetryCloseObserver(shutter);

		var observer = shutter.ForceOpenOverride.StateChanges()
			.Timeout(DateTimeOffset.Now.AddHours(8))
			.Where(x => !x.New?.IsOn() ?? false)
			.Subscribe(
				_ => CloseShutter(shutter),
				ex => Logger.Information("Shutter retry canceled due to {Exception}", ex.Message));
		_retryCloseShutterObservers.TryAdd(shutter, observer);
	}

	private void TryDisposeRetryCloseObserver(ShutterConfig shutter)
	{
		if (!_retryCloseShutterObservers.TryGetValue(shutter, out var existingObserver))
		{
			return;
		}

		existingObserver.Dispose();
		_retryCloseShutterObservers.Remove(shutter);
	}
}
