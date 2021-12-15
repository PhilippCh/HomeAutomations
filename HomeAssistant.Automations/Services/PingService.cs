using System;
using System.Net.NetworkInformation;
using System.Reactive.Linq;
using System.Text;
using HomeAssistant.Automations.Extensions;

namespace HomeAssistant.Automations.Services;

public class PingService
{
	private readonly byte[] _buffer;
	private readonly Ping _sender = new();

	private readonly PingOptions _options = new()
	{
		DontFragment = true
	};

	public PingService()
	{
		_buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
	}

	public IObservable<bool> Ping(string host, double timeoutMs) =>
		Observable
			.FromAsync(_ => _sender.SendPingAsync(host, MathExtensions.FloorToInt(timeoutMs), _buffer, _options))
			.Select(result => result.Status == IPStatus.Success);
}
