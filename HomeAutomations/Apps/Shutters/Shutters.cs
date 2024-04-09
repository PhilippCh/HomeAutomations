using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Shutters;

public class Shutters : BaseAutomation<Shutters, ShuttersConfig>
{
	private readonly NotificationService _notificationService;
	private readonly Dictionary<ShutterConfig, IDisposable> _retryCloseShutterObservers = new();

	public Shutters(BaseAutomationDependencyAggregate<Shutters, ShuttersConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		ObservableExtensions.IntervalSunset(Config.Latitude, Config.Longitude)
			.Delay(Config.CloseDelay)
			.Subscribe(_ => CloseAllShutters());

		Config.OpenSensorEntity.StateChanges().Subscribe(s => OnOpenButtonPressed(s.New?.State));

		// Automatically open the bedroom shutters *only* if:
		// - No one has been sleeping for at least OpenDelay time
		// - It is after OpenTime hours
		Config.SleepStateEntity.StateChanges()
			.Select(x => x.New?.IsOn() ?? true)
			.EmitDelayed(x => x == false, Config.OpenDelay)
			.CombineLatest(Observable.Interval(TimeSpan.FromMinutes(1)))
			.Select(x => x.First)
			.Where(x => x == false && DateTime.Now >= Config.OpenTime.GetActualTime(Config.Latitude, Config.Longitude))
			.DistinctUntilChanged()
			.Subscribe(_ => OpenShutters());

		return Task.CompletedTask;
	}

	private void OpenShutters()
	{
		// TODO: This wrapper method can be removed when the observable for automatic opening works properly. Call OpenAllShutters() in Subscribe() instead.
		_notificationService.SendNotification(Config.SleepStateDebugNotification);
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
