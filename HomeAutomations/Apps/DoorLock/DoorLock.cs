﻿using System.Linq;
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
	private const string OpenBothActionId = "OPEN_BOTH";

	private IDisposable? _ringSensorObserver;

	// We need to use an explicit state because the ring event only arrives after RTO has already been disabled on the opener.
	private DateTimeOffset? _lastRtoActivation;

	private readonly NotificationService _notificationService;

	public DoorLock(BaseAutomationDependencyAggregate<DoorLock, DoorLockConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		// Extra Security
		// --------------
		// - Disable RTO when automations restarted due to an unhandled exception.
		// - Check every 30 seconds if the RTO mechanism should be disabled and if so, do so.
		//   We do it this way instead of setting a timer when RTO is initially enabled to disable RTO after the timeout even if something
		//   in the enabling method fails and the timer for disabling is never actually created.
		DisableRingToOpen();
		Observable.Interval(TimeSpan.FromSeconds(30)).Subscribe(_ => CheckDisableRingToOpen());

		Context.Events
			.GetMobileAppActions(new[] { OpenOpenerActionId, OpenLockActionId })
			.Subscribe(OnOpenActionFired);

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

	private void OnOpenActionFired(string action)
	{
		Action callback = action switch
		{
			OpenOpenerActionId => () => PerformWithPeoplePresent(() => Config.OpenerEntity.Open()),
			OpenLockActionId => () => PerformWithPeoplePresent(() => Config.LockEntity.Open()),
			OpenBothActionId => OpenAllDoors,
			_ => () => Logger.Warning("Fired unknown action {Action}", action)
		};

		callback();
	}

	private void OpenAllDoors()
	{
		PerformWithPeoplePresent(
			() =>
			{
				Config.OpenerEntity.Open();
				Config.LockEntity.Open();
			});
	}

	private IObservable<EnableRtoEventData?> Authenticate(Event<EnableRtoEventData> e)
	{
		return e.Data?.Token != Config.Token
			? Observable.Throw<EnableRtoEventData>(new AuthenticationException($"Token {e.Data?.Token} is not authenticated"))
			: Observable.Return(e.Data);
	}

	private void EnableRingToOpen()
	{
		Logger.Debug("Enabling RTO");

		PerformWithPeoplePresent(() => Config.OpenerEntity.Unlock());

		_lastRtoActivation = DateTimeOffset.Now;
		_ringSensorObserver?.Dispose();
		_ringSensorObserver = Config.RingSensor.StateChanges()
			.Where(s => s.New?.IsOn() ?? false)
			.Subscribe(_ => OnRing());
	}

	private void OnRing()
	{
		// Sanity check to see if we're still in ring-to-open state. See comment on _isRtoActive.
		if (IsLockOpenable())
		{
			PerformWithPeoplePresent(() => Config.LockEntity.Open());
		}

		_lastRtoActivation = null;
	}

	private void CheckDisableRingToOpen()
	{
		if (!IsLockOpenable() && _lastRtoActivation != null)
		{
			Logger.Information("Disabling RTO due to timeout exceeded");
			DisableRingToOpen();
		}
	}

	private void DisableRingToOpen()
	{
		Config.OpenerEntity.Lock();
		_lastRtoActivation = null;
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

	private bool IsLockOpenable()
	{
		if (_lastRtoActivation == null)
		{
			return false;
		}

		return DateTimeOffset.Now - _lastRtoActivation < Config.RtoTimeout;
	}
}
