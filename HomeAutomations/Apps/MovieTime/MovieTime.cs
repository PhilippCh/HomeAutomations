﻿using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Models;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Models.Generated.HomeAutomation;
using HomeAutomations.Common.Extensions;

namespace HomeAutomations.Apps.MovieTime;

public class MovieTime : BaseAutomation<MovieTime, MovieTimeConfig>
{
	private MediaStatusMessage? _activeStatusMessage;

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
		Context.Events.Filter<RokuCommandEventData>(RokuCommandEventData.Id).Subscribe(e => OnRokuCommandReceived(e.Data));
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
			_ => () => Logger.Warning("No action defined for media state {key}.", e?.State)
		};

		action();
		_activeStatusMessage = e;
	}

	private void OnRokuCommandReceived(RokuCommandEventData? e)
	{
		Action action = e?.Key switch
		{
			"Play" => TogglePlayback,
			"Search" => ToggleLight,
			_ => () => Logger.Warning("No action defined for key {key}.", e?.Key)
		};

		action();
	}

	private async void TogglePlayback()
	{
		if (_activeStatusMessage == null || _activeStatusMessage.BaseUrl == null)
		{
			Logger.Warning("No active device to send remote command to.");

			return;
		}

		var client = new MediaHomeAutomationsClient(_activeStatusMessage.BaseUrl, new HttpClient());
		await client.TogglePlaybackAsync();
	}

	private void ToggleLight()
	{
		Config.Lights.ForEach(l => l.Toggle());
	}

	private void OnPause()
	{
		if (_activeStatusMessage?.State != MediaPlaybackState.NotPlaying)
		{
			Config.Lights.ForEach(l => l.TurnOn());
		}
	}

	private void OnResume()
	{
		if (_activeStatusMessage?.State != MediaPlaybackState.Playing)
		{
			Config.Lights.ForEach(l => l.TurnOff());
		}
	}
}