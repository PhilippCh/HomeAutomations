namespace HomeAutomations.Models;

public abstract record Config
{
	public bool Enabled { get; init; }
	public bool Debug { get; init; }
}
