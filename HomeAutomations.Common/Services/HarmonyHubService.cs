using HomeAutomations.Common.Models;
using HomeAutomations.Common.Models.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Common.Services;

public class HarmonyHubService
{
	private const string PowerOffActivityName = "PowerOff";

	private readonly IOptionsMonitor<HarmonyHubConfig> _config;
	private readonly ILogger<HarmonyHubService> _logger;

	public HarmonyHubService(IOptionsMonitor<HarmonyHubConfig> config, ILogger<HarmonyHubService> logger)
	{
		_logger = logger;
		_config = config;
	}

	public async Task<TaskExecutionResult> StartActivityAsync(string name)
	{
		/*using var client = CreateClient();

		if (client == null)
		{
			return new TaskExecutionResult(false, $"Could not connect to harmony hub");
		}

		var config = await client.GetConfigAsync();
		var activity = config.Activity.SingleOrDefault(a => a.Label == name);

		if (activity == null)
		{
			return new TaskExecutionResult(
				false,
				$"Found multiple or no activities for {name} (Available: {string.Join(", ", config.Activity.Select(a => a.Label))})");
		}

		await client.StartActivityAsync(int.Parse(activity.Id));*/

		return new TaskExecutionResult(true, $"Started harmony activity");
	}

	public async Task<TaskExecutionResult> StopActivityAsync(string name)
	{
		if (await IsActivityRunning(name))
		{
			await StartActivityAsync(PowerOffActivityName);
		}

		return new TaskExecutionResult(true, $"Stopped activity {name}.");
	}

	public async Task<string?> GetCurrentActivity()
	{
		/*using var client = CreateClient();

		if (client == null)
		{
			return string.Empty;
		}

		var currentActivityId = await client.GetCurrentActivityIdAsync();
		var activity = (await client.GetConfigAsync()).Activity
			.FirstOrDefault(a => a.Id == currentActivityId.ToString());

		return activity?.Label;*/
		return string.Empty;
	}

	private async Task<bool> IsActivityRunning(string name)
	{
		/*using var client = CreateClient();

		if (client == null)
		{
			return false;
		}

		var currentActivityId = await client.GetCurrentActivityIdAsync();
		var activity = (await client.GetConfigAsync()).Activity
			.FirstOrDefault(a => a.Label == name && a.Id == currentActivityId.ToString());

		return activity != null;*/
		return true;
	}

	/*private Client? CreateClient()
	{
		try
		{
			var credentials = _config.CurrentValue;
			var client = new Client(credentials.Host, credentials.Username, credentials.Password, bypassLogitech: true);

			client.Error += (o, e) => _logger.LogError("{Exception}", e.GetException().Message);
			client.Connect();
			_logger.LogDebug("Hub is connected and synced");

			return client;
		}
		catch (SocketException ex)
		{
			_logger.LogWarning("Could not establish a connection to harmony hub: {Exception}", ex.Message);

			return null;
		}
	}*/
}
