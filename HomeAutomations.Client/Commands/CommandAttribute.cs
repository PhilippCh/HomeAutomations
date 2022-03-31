using JetBrains.Annotations;

namespace HomeAutomations.Client.Commands;

[MeansImplicitUse]
public class CommandAttribute : Attribute
{
    public string Name { get; }

    public CommandAttribute(string name)
    {
        Name = name;
    }
}