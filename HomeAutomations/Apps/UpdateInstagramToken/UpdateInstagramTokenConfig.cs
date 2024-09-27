using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;

namespace HomeAutomations.Apps.UpdateInstagramToken;

public record UpdateInstagramTokenConfig : Config
{
	public string BaseUrl { get; init; }
	public string Token { get; init; }
	public string UpdateCrontab { get; init; }
	public string FilePath { get; init; }
	public string Host { get; init; }
	public string Username { get; init; }
	public string Password { get; init; }
	public Notification FailureNotification { get; init; }
}
