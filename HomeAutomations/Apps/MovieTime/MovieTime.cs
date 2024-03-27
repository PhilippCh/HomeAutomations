using System.Linq;
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

public class MovieTime : BaseAutomation<MovieTime, MovieTimeConfig>
{
	private const string MovieTimeActionId = "KINO";

	private readonly ActionSequencerService _actionSequencerService;
	private readonly EntityStatePriorityManager _entityStatePriorityManager;

	public MovieTime(
		BaseAutomationDependencyAggregate<MovieTime, MovieTimeConfig> aggregate,
		ActionSequencerService actionSequencerService,
		EntityStatePriorityManager entityStatePriorityManager)
		: base(aggregate)
	{
		_actionSequencerService = actionSequencerService;
		_entityStatePriorityManager = entityStatePriorityManager;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileAppActions(new[] { MovieTimeActionId })
			.Subscribe(_ => OnActionFired());

		// Source is a state attribute, so we require StateAllChanges here.
		Config.AvReceiver.Entity.StateAllChanges().Subscribe(x => OnAvReceiverStateChanged(x.New?.IsLikeOn(), x.New?.Attributes?.Source));

		return Task.CompletedTask;
	}

	private async void OnActionFired()
	{
		Logger.Information("Switching movie time on");

		await _actionSequencerService.RunAsync(
			new RunAction(() => Config.Lights.ForEach(x => x.TurnOn())),
			new RunAction(() => Config.AvReceiver.Entity.Toggle()),
			new RunAction(() => Config.AvReceiver.Entity.SelectSource(Config.AvReceiver.DefaultSource)),
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
						_entityStatePriorityManager.RemoveTargetStateForTag(x, nameof(MovieTime));
					}
					else
					{
						_entityStatePriorityManager.AddTargetState(x, nameof(MovieTime), false, 100);
					}
				});
		}
	}
}
