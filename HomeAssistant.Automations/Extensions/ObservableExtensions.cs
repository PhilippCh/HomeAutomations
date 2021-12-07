using System;
using System.Reactive.Linq;

namespace HomeAssistant.Automations.Extensions
{
    public static class ObservableExtensions
    {
        public static IObservable<long> Interval(TimeSpan interval, bool emitImmediately = false)
        {
            var observable = Observable.Interval(interval);

            return emitImmediately ? observable.StartWith(-1) : observable;
        }
    }
}