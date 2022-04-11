using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cronos;

namespace HomeAutomations.Extensions;

public static class CronjobExtensions
{
	private static readonly TimeSpan MinTimeSpan = TimeSpan.FromMilliseconds(500);
	private static readonly TimeSpan WaitDelay = TimeSpan.FromMinutes(1);

	public static async Task ScheduleJob(string cronSchedule, Action action, bool runOnStartup = false, CancellationToken cancellationToken = default)
	{
		await ScheduleJob(
			cronSchedule, async () =>
			{
				action();
				await Task.CompletedTask;
			}, runOnStartup, cancellationToken);
	}

	public static async Task ScheduleJob(string cronSchedule, Func<Task> action, bool runOnStartup = false, CancellationToken cancellationToken = default)
	{
		var expression = CronExpression.Parse(cronSchedule);
		var today = DateTime.Today;
		var occurrencesToday = expression.GetOccurrences(today, today.AddDays(1), TimeZoneInfo.Local);
		var next = expression.GetNextOccurrence(DateTimeOffset.Now, TimeZoneInfo.Local);

		if (next == null)
		{
			await Task.CompletedTask;
		}

		if (!cancellationToken.IsCancellationRequested && runOnStartup)
		{
			await action();
		}

		while (!cancellationToken.IsCancellationRequested)
		{
			while (next!.Value - DateTimeOffset.Now > MinTimeSpan && !cancellationToken.IsCancellationRequested)
			{
				try
				{
					await Task.Delay(WaitDelay, cancellationToken);
				}
				catch (TaskCanceledException)
				{
					break;
				}
			}

			if (!cancellationToken.IsCancellationRequested)
			{
				await action();
			}

			next = expression.GetNextOccurrence(DateTimeOffset.Now + MinTimeSpan, TimeZoneInfo.Local);
		}
	}
}
