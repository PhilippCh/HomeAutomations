using System;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cronos;

namespace HomeAssistant.Automations.Extensions
{
    public static class CronjobExtensions
    {
        private static readonly TimeSpan MinTimeSpan = TimeSpan.FromMilliseconds(500);
        private static readonly TimeSpan WaitDelay = TimeSpan.FromMinutes(1);

        public static async Task ScheduleJob(string cronSchedule, Action action, CancellationToken cancellationToken)
        {
            await ScheduleJob(cronSchedule, async () =>
            {
                action();
                await Task.CompletedTask;
            }, cancellationToken);
        }
        
        public static async Task ScheduleJob(string cronSchedule, Func<Task> action, CancellationToken cancellationToken)
        {
            var expression = CronExpression.Parse(cronSchedule);
            var next = expression.GetNextOccurrence(DateTimeOffset.Now, TimeZoneInfo.Local);
            
            if (next == null)
            {
                await Task.CompletedTask;
            }

            while (!cancellationToken.IsCancellationRequested)
            {
                while (next!.Value - DateTimeOffset.Now > MinTimeSpan && !cancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(WaitDelay, cancellationToken);
                }

                if (!cancellationToken.IsCancellationRequested)
                {
                    await action();
                }
                
                next = expression.GetNextOccurrence(DateTimeOffset.Now + MinTimeSpan, TimeZoneInfo.Local);
            }
        }
    }
}