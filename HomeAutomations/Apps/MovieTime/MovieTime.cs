using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Models;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MovieTime;

public class MovieTime : BaseAutomation<MovieTime, MovieTimeConfig>
{
	private MediaPlaybackState? _previousPlaybackState;

	private readonly MqttService _mqttService;
	private readonly HarmonyHubService _harmonyHubService;

	public MovieTime(BaseAutomationDependencyAggregate<MovieTime, MovieTimeConfig> aggregate, MqttService mqttService, HarmonyHubService harmonyHubService)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_harmonyHubService = harmonyHubService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		(await _mqttService.GetMessagesForTopic<MediaStatusMessage>(Config.StatusTopic)).Subscribe(OnStatusMessageReceived);
	}

	private async void OnStatusMessageReceived(MediaStatusMessage? e)
	{
		var currentActivity = await _harmonyHubService.GetCurrentActivity();

		if (!Config.SupportedActivities.Contains(currentActivity))
		{
			return; // We're currently not watching a movie.
		}

		Action action = e?.State switch
		{
			MediaPlaybackState.NotPlaying => OnPause,
			MediaPlaybackState.Playing => OnResume,
			_ => () => {}
		};

		action();
		_previousPlaybackState = e?.State;
	}

	private void OnPause()
	{
		if (_previousPlaybackState != MediaPlaybackState.NotPlaying)
		{
			foreach (var light in Config.Lights)
			{
				light.TurnOn();
			}
		}
	}

	private void OnResume()
	{
		if (_previousPlaybackState != MediaPlaybackState.Playing)
		{
			foreach (var light in Config.Lights)
			{
				light.TurnOff();
			}
		}
	}
}
