using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Shutters;

public class Shutters(BaseAutomationDependencyAggregate<Shutters, ShuttersConfig> aggregate, NotificationService notificationService, IMqttEntityManager entityManager)
	: BaseAutomation<Shutters, ShuttersConfig>(aggregate)
{
	private readonly Dictionary<ShutterConfig, IDisposable> _retryCloseShutterObservers = new();

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await entityManager.CreateAsync(Config.OpenShuttersSensorEntity.EntityId, "Open shutters sensor");

		ObservableExtensions.IntervalSunset(Config.Latitude, Config.Longitude)
			.Delay(Config.CloseDelay)
			.Subscribe(_ => CloseAllShutters());

		Config.OpenSensorEntity.StateChanges().Subscribe(s => OnOpenButtonPressed(s.New?.State));

		// Automatically open the bedroom shutters *only* if:
		// - No one has been sleeping for at least OpenDelay time
		// - It is after OpenTime hours
		Config.SleepStateEntity.ToObservableState()
			.Select(x => x ?? true)
			.EmitDelayed(x => x == false, Config.OpenDelay)
			.Where(x => !x)
			.CombineTime()
			.Where(x => !x.Value && x.Time >= Config.OpenTime.GetActualTime(Config.Latitude, Config.Longitude))
			.DistinctUntilChanged()
			.SubscribeAsync(async x => await SetOpenShuttersSensorStateAsync(x.Value));

		// Open the shutters when the open sensor is triggered
		Config.OpenSensorEntity.StateChanges()
			.Where(x => x.New?.IsOn() ?? false)
			.Subscribe(_ => OpenShutters());
	}

	private async Task SetOpenShuttersSensorStateAsync(bool shouldOpen)
	{
		await entityManager.SetBinaryStateAsync(Config.OpenShuttersSensorEntity.EntityId, shouldOpen);
	}

	private void OpenShutters()
	{
		// TODO: Actually open the shutters.
		notificationService.SendNotification(Config.SleepStateDebugNotification);
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
