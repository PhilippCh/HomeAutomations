using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.Shutters;

public class Shutters : BaseAutomation<Shutters, ShuttersConfig>
{
	private readonly Dictionary<ShutterConfig, IDisposable> _retryCloseShutterObservers = new();
	private readonly INotificationService _notificationService;
	private readonly IMqttEntityManager _entityManager;
	private readonly IClockService _clockService;
	private readonly IScheduler _scheduler;

	// ReSharper disable once ConvertToPrimaryConstructor | Primary constructor displays values as null, see https://github.com/dotnet/roslyn/issues/70730.
	public Shutters(BaseAutomationDependencyAggregate<Shutters, ShuttersConfig> aggregate,
	                INotificationService notificationService,
	                IMqttEntityManager entityManager,
	                IClockService clockService,
	                IScheduler scheduler)
		: base(aggregate)
	{
		_notificationService = notificationService;
		_entityManager = entityManager;
		_clockService = clockService;
		_scheduler = scheduler;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await _entityManager.CreateAsync(Config.OpenShuttersSensorEntity.EntityId, "Open shutters sensor");

		ObservableExtensions.IntervalSunset(Config.Latitude, Config.Longitude, () => _clockService.Now, _scheduler)
			.Delay(Config.CloseDelay, _scheduler)
			.Do(_ => Logger.Information("Closing shutters due to sunset"))
			.Subscribe(_ => CloseAllShutters());

		Config.OpenSensorEntity.StateChanges().Subscribe(s => OnOpenButtonPressed(s.New?.State));

		// Automatically open the bedroom shutters *only* if:
		// - No one has been sleeping for at least OpenDelay time
		// - It is after OpenTime hours
		ObservableExtensions
			.Between(
				() => Config.OpenTime.GetActualTime(AppConstants.Latitude, AppConstants.Longitude, _clockService.Now)!.Value,
				() => _clockService.Now.Date.Add(TimeSpan.Parse("23:59:59")),
				() => _clockService.Now,
				_scheduler)
			.CombineLatest(Config.SleepStateEntity.ToObservableState()
				.Select(x => x ?? true))
			.Select(x => (IsInTime: x.First, IsSleeping: x.Second))
			.Do(x => Logger.Information("Is in time: {IsInTime}, Is sleeping: {IsSleeping}", x.IsInTime, x.IsSleeping))
			.Select(x => x is
			{
				IsInTime: true,
				IsSleeping: false
			})
			.DistinctUntilChanged()
			.SubscribeAsync(async x => await SetOpenShuttersSensorStateAsync(x));

		// Open the shutters when the open sensor is triggered.
		Config.OpenSensorEntity.StateChanges()
			.Where(x => (x.New?.IsOn() ?? false) && (x.Old?.IsOff() ?? false))
			.Subscribe(_ => OpenShutters());
	}

	private async Task SetOpenShuttersSensorStateAsync(bool shouldOpen)
	{
		await _entityManager.SetBinaryStateAsync(Config.OpenShuttersSensorEntity.EntityId, shouldOpen);
	}

	private void OpenShutters()
	{
		// TODO: Actually open the shutters.
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
