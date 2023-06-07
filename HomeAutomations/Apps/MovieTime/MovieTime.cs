using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Constants;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.MovieTime;

[Focus]
public class MovieTime : BaseAutomation<MovieTime, MovieTimeConfig>
{
	private const string MovieTimeActionId = "KINO";

	private readonly ActionSequencerService _actionSequencerService;

	public MovieTime(BaseAutomationDependencyAggregate<MovieTime, MovieTimeConfig> aggregate, ActionSequencerService actionSequencerService)
		: base(aggregate)
	{
		_actionSequencerService = actionSequencerService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.Events
			.GetMobileAppActions(new[] { MovieTimeActionId })
			.Subscribe(_ => OnActionFired());

		Context.Events
			.Filter<StateChangedEvent>(EventConstants.StateChanged)
			.Where(x => x.Data?.EntityId == "")
			.Subscribe();

		return Task.CompletedTask;
	}

	private async void OnActionFired()
	{
		Logger.Information("Switching movie time on");

		await _actionSequencerService.RunAsync(
			new RunAction(() => Config.Lights.ForEach(x => x.TurnOn())),
			new RunAction(() => SendRemoteCommand("AVReceiver", commands: "source_streambox")),
			new RunAction(() => SendRemoteCommand("AVReceiver", commands: "power"), 1),
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
}
