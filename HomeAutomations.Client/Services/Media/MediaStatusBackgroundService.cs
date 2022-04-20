using System.Reactive.Linq;
using DeviceId;
using HomeAutomations.Common.Models;
using HomeAutomations.Common.Services;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Client.Services.Media;

public class MediaStatusBackgroundService : IHostedService, IDisposable
{
	private readonly MediaControllerService _mediaControllerService;
	private readonly MqttService _mqttService;
	private IDisposable? _observer;

	private readonly MediaStatusConfig _config;
	private readonly ILogger<MediaStatusBackgroundService> _logger;

	public MediaStatusBackgroundService(
		IOptionsMonitor<MediaStatusConfig> config,
		MediaControllerService mediaControllerService,
		MqttService mqttService,
		ILogger<MediaStatusBackgroundService> logger)
	{
		_mediaControllerService = mediaControllerService;
		_mqttService = mqttService;
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
		var statusMessage = await _mediaControllerService.GetStatus();
		await _mqttService.PublishMessage(statusMessage, CancellationToken.None, _config.BaseTopic, statusMessage.DeviceId);
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
