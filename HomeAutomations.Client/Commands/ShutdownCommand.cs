using System.Diagnostics;

namespace HomeAutomations.Client.Commands;

[Command("shutdown")]
public class ShutdownCommand : ICommand
{
    public Task ExecuteAsync()
    {
        var psi = new ProcessStartInfo("shutdown","/s /t 0")
        {
            CreateNoWindow = true,
            UseShellExecute = false
        };
            
        Process.Start(psi);
        return Task.CompletedTask;
    }
}