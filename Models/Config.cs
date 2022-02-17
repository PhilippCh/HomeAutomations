namespace HomeAutomations.Models;

public abstract record Config
{
	public bool Enabled { get; init; } = true;
	public bool Debug { get; init; }
}
