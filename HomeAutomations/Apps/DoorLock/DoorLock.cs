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

public class DoorLock : BaseAutomation<DoorLock, DoorLockConfig>
{
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
		Context.Events.Filter<EnableRtoEventData>(EnableRtoEventData.Id)
			.SwitchMap(Authenticate)
			.Catch<EnableRtoEventData?, AuthenticationException>(
				ex =>
				{
					Logger.Warning("Authentication error: {Message}", ex.Message);

					return Observable.Empty<EnableRtoEventData>();
				})
			.Subscribe(_ => EnableRingToOpen());

		Context.Events
			.GetMobileNotificationActions(DoorLockNotificationActions.Actions)
			.Subscribe(OnNotificationActionFired);

		foreach (var person in Config.EnabledPersons)
		{
			person.StateChanges()
				.Where(
					x =>
					{
						var accuracy = x.New?.Attributes?.GpsAccuracy ?? double.MaxValue;
						var isAccurateMeasurement = accuracy < Config.GpsAccuracyThreshold;

						if (!isAccurateMeasurement)
						{
							Logger.Information(
								"GPS accuracy of {Accuracy} did not meet reporting threshold of {Threshold}, will not trigger door automation", accuracy,
								Config.GpsAccuracyThreshold);
						}

						return isAccurateMeasurement;
					})
				.Select(x => (Old: ZoneParser.Parse(x.Old?.State), New: ZoneParser.Parse(x.New?.State)))
				.Where(x => x.Old != x.New && x.New == Zone.Home)
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

	private void OnNotificationActionFired(string action)
	{
		Action callback = action switch
		{
			DoorLockNotificationActions.KeepActive => KeepDoorActive,
			_ => () => Logger.Warning("Fired unknown notification action {Action}", action)
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
			return Observable.Throw<EnableRtoEventData>(new AuthenticationException($"Token {e.Data?.Token} is not authenticated."));
		}

		return Observable.Return(e.Data);
	}

	private void EnableRingToOpen()
	{
		Config.OpenerEntity.Lock(); // Force state change to reset native opener RTO timer.
		Config.OpenerEntity.Unlock();

		_isRtoActive = true;
		_ringSensorObserver?.Dispose();
		_ringSensorObserver = Config.RingSensor.StateChanges()
			.Where(s => s.New?.IsOn() ?? false)
			.Subscribe(_ => OnRing());

		_rtoTimeoutObserver?.Dispose();
		_rtoTimeoutObserver = Observable.Timer(Config.RtoTimeout).Subscribe(_ => Config.OpenerEntity.Lock());
	}

	private void OnRing()
	{
		// Sanity check to see if we're still in ring-to-open state. See comment on _isRtoActive.
		if (_isRtoActive)
		{
			Config.LockEntity.Open();
		}

		if (_keepDoorActive)
		{
			EnableRingToOpen();
		}

		_isRtoActive = false;
	}
}
