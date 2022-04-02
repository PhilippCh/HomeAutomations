using System.Reactive.Linq;
using DeviceId;
using HomeAutomations.Client.Media;
using HomeAutomations.Common.Services;
using Microsoft.Extensions.Options;
using ILogger = Serilog.ILogger;

namespace HomeAutomations.Client.Services.Media;

public class MediaStatusBackgroundService : IHostedService, IDisposable
{
	private readonly MediaControllerService _mediaControllerService;
	private readonly MqttService _mqttService;
	private readonly HostService _hostService;
	private IDisposable? _observer;

	private readonly MediaStatusConfig _config;
	private readonly ILogger<MediaStatusBackgroundService> _logger;

	public MediaStatusBackgroundService(
		IOptionsMonitor<MediaStatusConfig> config,
		MediaControllerService mediaControllerService,
		MqttService mqttService,
		HostService hostService,
		ILogger<MediaStatusBackgroundService> logger)
	{
		_mediaControllerService = mediaControllerService;
		_mqttService = mqttService;
		_hostService = hostService;
		_config = config.CurrentValue;
		_logger = logger;
	}

	public Task StartAsync(CancellationToken stoppingToken)
	{
		_logger.LogInformation("Starting media status background check every {interval}.", _config.UpdateInterval);
		_observer = Observable.Interval(_config.UpdateInterval).Subscribe(_ => UpdateMediaStatus());

		return Task.CompletedTask;
	}

	private async void UpdateMediaStatus()
	{
		var deviceId = new DeviceIdBuilder()
			.AddMachineName()
			.AddMacAddress()
			.ToString();
		var status = _mediaControllerService.GetStatus() with { DeviceId = deviceId, BaseUrl = $"http://{_hostService.GetLocalIpAddress()}:{Constants.Port}"};

		await _mqttService.PublishMessage(status, CancellationToken.None, _config.BaseTopic);
	}

	public Task StopAsync(CancellationToken stoppingToken)
	{
		_logger.LogInformation("Stopping media service background check.");
		_observer?.Dispose();

		return Task.CompletedTask;
	}

	public void Dispose()
	{
		_observer?.Dispose();
	}
}
