using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.DoorLock;

[Focus]
public class DoorLock : BaseAutomation<DoorLock, DoorLockConfig>
{
	private IDisposable? _rtoTimeoutObserver;
	private IDisposable? _ringSensorObserver;

	// We need to use an explicit state because the ring event only arrives after RTO has already been disabled on the opener.
	private bool _isRtoActive;

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

		// Disable RTO by default to clear up inconsistent statues due to unexpected restarts.
		Config.OpenerEntity.Lock();

		return Task.CompletedTask;
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
		_notificationService.SendNotification(Config.ArrivalNotification);
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

		_isRtoActive = false;
	}
}
