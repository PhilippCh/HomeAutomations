﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.MovieTime;

[Focus]
public class MovieTime(
	BaseAutomationDependencyAggregate<MovieTime, MovieTimeConfig> aggregate,
	ActionSequencerService actionSequencerService,
	EntityStatePriorityManager entityStatePriorityManager) : BaseAutomation<MovieTime, MovieTimeConfig>(aggregate)
{
	private const string MovieTimeActionId = "KINO";

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileAppActions(new[] { MovieTimeActionId })
			.Subscribe(_ => StartMovieTime(new MovieTimeServiceData
			{
				AvReceiverSource = Config.AvReceiver.DefaultSource
			}));

		Context.RegisterServiceCallBack<MovieTimeServiceData>("movie_time", StartMovieTime);

		// Source is a state attribute, so we require StateAllChanges here.
		Config.AvReceiver.Entity
			.StateChangesWithCurrentState<MediaPlayerEntity, MediaPlayerAttributes>()
			.Subscribe(x => OnAvReceiverStateChanged(x.New?.IsLikeOn(), x.New?.Attributes?.Source));

		return Task.CompletedTask;
	}

	private async void StartMovieTime(MovieTimeServiceData data)
	{
		Logger.Information("Switching movie time on");

		await actionSequencerService.RunAsync(
			new RunAction(() => Config.Lights.ForEach(x => x.TurnOn())),
			new RunAction(() => Config.AvReceiver.Entity.TurnOn()),
			new RunAction(() => Config.AvReceiver.Entity.SelectSource(data.AvReceiverSource ?? Config.AvReceiver.DefaultSource), 5),
			new RunAction(() => SendRemoteCommand("Beamer", commands: "power", repeats: 2, delay: 2), 1)
		);
	}

	private void SendRemoteCommand(string device, long repeats = 1, double delay = 0.4, params string[] commands)
	{
		var command = commands.Length == 1 ? commands[0] : string.Join("\n", commands.Select(x => $"- {x}"));
		Config.Remote.SendCommand(
			new RemoteSendCommandParameters
			{
				Device = device,
				Command = command,
				NumRepeats = repeats,
				DelaySecs = delay,
				HoldSecs = 0
			});
	}

	private void OnAvReceiverStateChanged(bool? powerState, string? source)
	{
		var isOff = powerState == null || !powerState.Value;

		Config.AvReceiver.Subwoofer.CallService(isOff ? "turn_off" : "turn_on");

		foreach (var toggleEntity in Config.AvReceiver.ToggleEntities)
		{
			var isValidSource = source != null && toggleEntity.MediaSources.Contains(source);

			Logger.Information("Does AV receiver source {Source} disable lights? {IsValidSource}", source, isValidSource);

			toggleEntity.Entities.ForEach(
				x =>
				{
					if (isOff || !isValidSource)
					{
						entityStatePriorityManager.RemoveTargetStateForTag(x, nameof(MovieTime));
					}
					else
					{
						entityStatePriorityManager.AddTargetState(x, nameof(MovieTime), false, 100);
					}
				});
		}
	}
}
