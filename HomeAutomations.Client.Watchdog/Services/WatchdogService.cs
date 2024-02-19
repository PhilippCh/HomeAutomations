using System.Diagnostics;
using HomeAutomations.Client.Watchdog.Util;

namespace HomeAutomations.Client.Watchdog.Services;

public sealed class WatchdogService : BackgroundService
{
	private readonly ILogger<WatchdogService> _logger;
	private readonly IConfiguration _config;

	public WatchdogService(ILogger<WatchdogService> logger, IConfiguration config)
	{
		_logger = logger;
		_config = config;
	}

	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		while (!stoppingToken.IsCancellationRequested)
		{
			if (!IsProcessRunning("HomeAutomations.Client"))
			{
				RestartProcess();
			}

			await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
		}
	}

	private bool IsProcessRunning(string processName) => Process.GetProcessesByName(processName).Length > 0;

	private void RestartProcess()
	{
		_logger.LogInformation("Restarting HomeAutomations.Client process");

		var workDir = _config.GetValue<string>("WorkDir");
		var executablePath = Path.Combine(workDir, _config.GetValue<string>("ExecutableName"));
		ProcessAsUser.Launch(executablePath, workDir);
	}
}
