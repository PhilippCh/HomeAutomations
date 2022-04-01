namespace HomeAutomations.Common.Models.Config;

public record HarmonyHubConfig
{
	public string Host { get; init; }
	public string Username { get; init; }
	public string Password { get; init; }
}
