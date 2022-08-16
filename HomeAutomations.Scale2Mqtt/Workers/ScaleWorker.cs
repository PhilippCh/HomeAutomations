using HomeAutomations.Scale2Mqtt.Services;

namespace HomeAutomations.Scale2Mqtt.Workers;

public class ScaleWorker : BackgroundService
{
	private readonly ILogger<ScaleWorker> _logger;
	private readonly ScaleService _scaleService;

	public ScaleWorker(ILogger<ScaleWorker> logger, ScaleService scaleService)
	{
		_logger = logger;
		_scaleService = scaleService;
	}

	protected override Task ExecuteAsync(CancellationToken stoppingToken)
	{
		_scaleService.Start();

		return Task.CompletedTask;
	}
}
