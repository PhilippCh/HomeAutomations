namespace HomeAutomations.Common.Models.Config;

public record MqttConfig : Config
{
	public string Host { get; init; } = "localhost";
	public int Port { get; init; } = 1883;
	public string Username { get; init; } = "";
	public string Password { get; init; } = "";
}
