namespace HomeAutomations.Client.Commands;

public interface ICommand
{
    Task ExecuteAsync();
}