using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Services;

public record RunAction(Action Action, double DelayMs = 0);

public class ActionSequencerService
{
	public async Task RunAsync(params RunAction[] actions) => await RunAsync(actions.AsEnumerable());

	public async Task RunAsync(IEnumerable<RunAction> actions)
	{
		foreach (var runAction in actions)
		{
			if (runAction.DelayMs > 0)
			{
				await Task.Delay(TimeSpan.FromMilliseconds(runAction.DelayMs));
			}

			runAction.Action();
		}
	}
}
