using System.Runtime.InteropServices;

namespace HomeAutomations.Client.Commands;

[Command("sleep")]
public class SleepCommand : ICommand
{
    [DllImport("Powrprof.dll", CharSet=CharSet.Auto, ExactSpelling=true)]
    private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
        
    public Task ExecuteAsync()
    {
        SetSuspendState(false, true, true);
        return Task.CompletedTask;
    }
}