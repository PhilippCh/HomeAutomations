using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.AvReceiver;

[Focus]
public class AvReceiver(
	BaseAutomationDependencyAggregate<AvReceiver, AvReceiverConfig> aggregate,
	ActionSequencerService actionSequencerService,
	EntityStatePriorityManager entityStatePriorityManager) : BaseAutomation<AvReceiver, AvReceiverConfig>(aggregate)
{
	private const string MovieTimeActionId = "KINO";
	private const string RecordPlayerActionId = "PLAY_RECORD";

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileAppActions([MovieTimeActionId])
			.Subscribe(
				_ => SwitchMovieTime(
					new MovieTimeServiceData
					{
						AvReceiverSource = Config.AvReceiver.DefaultSource
					}));

		Context.Events
			.GetMobileAppActions(new[] { RecordPlayerActionId })
			.Subscribe(_ => SwitchRecordPlayer());

		Context.RegisterServiceCallBack<MovieTimeServiceData>("movie_time", SwitchMovieTime);

		// Source is a state attribute, so we require StateAllChanges here.
		Config.AvReceiver.Entity
			.StateChangesWithCurrentState<MediaPlayerEntity, MediaPlayerAttributes>()
			.Subscribe(x => OnAvReceiverStateChanged(x.New?.IsLikeOn(), x.New?.Attributes?.Source));

		return Task.CompletedTask;
	}

	private async void SwitchMovieTime(MovieTimeServiceData data)
	{
		var source = data.AvReceiverSource ?? Config.AvReceiver.DefaultSource;
		var targetState = !Config.AvReceiver.Entity.IsOff() && Config.AvReceiver.Entity.Attributes?.Source == source;

		Logger.Information("Switching movie time {TargetState}", targetState ? "on" : "off");

		await actionSequencerService.RunAsync(
			new RunAction(() => Config.Lights.ForEach(x => x.TurnOn())),
			new RunAction(() => Config.AvReceiver.Entity.Switch(targetState)),
			new RunAction(() => Config.AvReceiver.Entity.SelectSource(source), 5000),
			new RunAction(() => SendRemoteCommand("Beamer", commands: "power", repeats: 2, delaySecs: 2), 1000)
		);
	}

	private async void SwitchRecordPlayer()
	{
		var targetState = !Config.RecordPlayer.IsOn();
		Logger.Information("Switching record player {TargetState}", targetState ? "on" : "off");

		var runActions = new List<RunAction>
		{
			new(() => Config.AvReceiver.Entity.Switch(targetState)),
			new(() => Config.RecordPlayer.Switch(targetState))
		};

		if (targetState)
		{
			runActions.Add(new RunAction(() => Config.AvReceiver.Entity.SelectSource(Config.AvReceiver.RecordPlayerSource), 5000));
		}

		await actionSequencerService.RunAsync(runActions);
	}

	private void SendRemoteCommand(string device, long repeats = 1, double delaySecs = 0.4, params string[] commands)
	{
		var command = commands.Length == 1 ? commands[0] : string.Join("\n", commands.Select(x => $"- {x}"));
		Config.Remote.SendCommand(
			new RemoteSendCommandParameters
			{
				Device = device,
				Command = command,
				NumRepeats = repeats,
				DelaySecs = delaySecs,
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
						entityStatePriorityManager.RemoveTargetStateForTag(x, nameof(AvReceiver));
					}
					else
					{
						entityStatePriorityManager.AddTargetState(
							x, nameof(AvReceiver), y =>
							{
								y.CallService("turn_on", new LightTurnOnParameters { BrightnessPct = 30 });
							}, 100);
					}
				});
		}
	}
}
