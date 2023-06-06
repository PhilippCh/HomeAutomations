﻿using System.Linq;
using System.Reflection.Metadata;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.DoorLock;

[Focus]
public class DoorLock : BaseAutomation<DoorLock, DoorLockConfig>
{
	private const string OpenOpenerActionId = "OPEN_OPENER";
	private const string OpenLockActionId = "OPEN_LOCK";

	private IDisposable? _rtoTimeoutObserver;
	private IDisposable? _ringSensorObserver;

	// We need to use an explicit state because the ring event only arrives after RTO has already been disabled on the opener.
	private bool _isRtoActive;
	private bool _keepDoorActive;

	private readonly NotificationService _notificationService;

	public DoorLock(BaseAutomationDependencyAggregate<DoorLock, DoorLockConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileAppActions(new[] { OpenOpenerActionId, OpenLockActionId })
			.Subscribe(OnOpenActionFired);

		Context.Events
			.GetMobileAppNotificationActions(DoorLockNotificationActions.Actions)
			.Subscribe(OnNotificationActionFired);

		foreach (var person in Config.EnabledPersons)
		{
			person.StateChanges()
				.Where(x => x.New?.Attributes?.IsGpsPositionAccurate(Config.GpsAccuracyThreshold) ?? false)
				.Select(x => (Old: ZoneParser.Parse(x.Old?.State), New: ZoneParser.Parse(x.New?.State)))
				.Where(x => x.Old != x.New && x.New == Zone.Home)
				.Select(_ => new EnableRtoEventData())
				.Merge(GetEnableRtoEvents())
				.Subscribe(
					_ =>
					{
						_notificationService.SendNotification(Config.ArrivalNotification);
						EnableRingToOpen();
					});
		}

		// Disable RTO by default to clear up inconsistent statues due to unexpected restarts.
		Config.OpenerEntity.Lock();

		return Task.CompletedTask;
	}

	private IObservable<EnableRtoEventData?> GetEnableRtoEvents()
	{
		return Context.Events.Filter<EnableRtoEventData>(EnableRtoEventData.Id)
			.SwitchMap(Authenticate)
			.Catch<EnableRtoEventData?, AuthenticationException>(
				ex =>
				{
					Logger.Warning("Authentication error: {Message}", ex.Message);

					return Observable.Empty<EnableRtoEventData>();
				});
	}

	private void OnNotificationActionFired(string action)
	{
		Action callback = action switch
		{
			DoorLockNotificationActions.KeepActive => KeepDoorActive,
			_ => () => Logger.Warning("Fired unknown notification action {Action}", action)
		};

		callback();
	}

	private void OnOpenActionFired(string action)
	{
		Action callback = action switch
		{
			OpenOpenerActionId => () => Config.OpenerEntity.Open(),
			OpenLockActionId => () => Config.LockEntity.Open(),
			_ => () => Logger.Warning("Fired unknown action {Action}", action)
		};

		callback();
	}

	private void KeepDoorActive()
	{
		_keepDoorActive = true;
		EnableRingToOpen();
	}

	private IObservable<EnableRtoEventData?> Authenticate(Event<EnableRtoEventData> e)
	{
		if (e.Data?.Token != Config.Token)
		{
			return Observable.Throw<EnableRtoEventData>(new AuthenticationException($"Token {e.Data?.Token} is not authenticated"));
		}

		return Observable.Return(e.Data);
	}

	private void EnableRingToOpen()
	{
		Logger.Debug("Enabling RTO");

		Config.OpenerEntity.Unlock();

		_isRtoActive = true;
		_ringSensorObserver?.Dispose();
		_ringSensorObserver = Config.RingSensor.StateChanges()
			.Where(s => s.New?.IsOn() ?? false)
			.Subscribe(_ => OnRing());

		_rtoTimeoutObserver?.Dispose();
		_rtoTimeoutObserver = Observable.Timer(Config.RtoTimeout)
			.Subscribe(_ => DisableRingToOpen());
	}

	private void OnRing()
	{
		// Sanity check to see if we're still in ring-to-open state. See comment on _isRtoActive.
		if (_isRtoActive)
		{
			PerformWithPeoplePresent(() => Config.LockEntity.Open());
		}

		if (_keepDoorActive)
		{
			Logger.Debug("Reenable RTO due to ringing withing timeframe");
			PerformWithPeoplePresent(EnableRingToOpen);
		}

		_isRtoActive = false;
	}

	private void DisableRingToOpen()
	{
		Config.OpenerEntity.Lock();
		_isRtoActive = false;
	}

	private void PerformWithPeoplePresent(Action action)
	{
		var presentPersons = Config.EnabledPersons
			.Where(x => (x.Attributes?.IsGpsPositionAccurate(Config.GpsAccuracyThreshold) ?? false) && ZoneParser.Parse(x.State) == Zone.Home)
			.ToList();

		if (!presentPersons.Any())
		{
			Logger.Warning("Will not perform action because no person is present");
			return;
		}

		var entityNames = presentPersons.Select(x => x.GetName());
		Logger.Information("Performing action because of present persons: {Persons}", string.Join(", ", entityNames));

		action();
	}
}
