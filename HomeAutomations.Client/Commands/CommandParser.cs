using System.Reflection;

namespace HomeAutomations.Client.Commands;

public class CommandParser
{
    private readonly IReadOnlyDictionary<string, ICommand?> _commands;

    public CommandParser()
    {
        _commands = GetCommands();
    }

    public ICommand? Get(string name)
    {
        _commands.TryGetValue(name.ToLowerInvariant(), out var command);
        return command;
    }

    private IReadOnlyDictionary<string, ICommand?> GetCommands() =>
        Assembly.GetExecutingAssembly().GetTypes()
            .Select(t => (Type: t, Attribute: t.GetCustomAttribute<CommandAttribute>()))
            .Where(t => t.Attribute != null)
            .Select(t => new KeyValuePair<string, ICommand?>(t.Attribute!.Name, Activator.CreateInstance(t.Type)! as ICommand))
            .ToDictionary(t => t.Key.ToLowerInvariant(), t => t.Value);
}