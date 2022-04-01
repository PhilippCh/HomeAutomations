using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.MovieTime;

public class MovieTime : BaseAutomation<MovieTime, MovieTimeConfig>
{
	private readonly HarmonyHubService _harmonyHubService;

	public MovieTime(BaseAutomationDependencyAggregate<MovieTime, MovieTimeConfig> aggregate, HarmonyHubService harmonyHubService)
		: base(aggregate)
	{
		_harmonyHubService = harmonyHubService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}
}
