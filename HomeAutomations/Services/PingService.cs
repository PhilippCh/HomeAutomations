using System.Net.NetworkInformation;
using System.Reactive;
using System.Text;
using HomeAutomations.Extensions;

namespace HomeAutomations.Services;

public class PingService : BaseService<PingService>
{
	private readonly byte[] _buffer;

	private readonly PingOptions _options = new()
	{
		DontFragment = true
	};

	public PingService(BaseServiceDependencyAggregate<PingService> aggregate)
		: base(aggregate)
	{
		_buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
	}

	public IObservable<Unit> PingInterval(string host, double intervalMs, TimeSpan? afterSuccessThrottle = default)
	{
		var ping = Observable
			.Interval(TimeSpan.FromMilliseconds(intervalMs))
			.Do(_ => Logger.Debug("Pinging {host}.", host))
			.Select(_ => Ping(host, intervalMs * 0.8f))
			.Switch()
			.Where(result => result)
			.Select(_ => new Unit());

		if (afterSuccessThrottle != null)
		{
			ping = ping.Throttle(afterSuccessThrottle.Value);
		}

		return ping;
	}

	public IObservable<bool> Ping(string host, double timeoutMs)
	{
		var sender = new Ping();

		return Observable
			.FromAsync(_ => sender.SendPingAsync(host, MathExtensions.FloorToInt(timeoutMs), _buffer, _options))
			.Select(result => result.Status == IPStatus.Success);
	}
}
