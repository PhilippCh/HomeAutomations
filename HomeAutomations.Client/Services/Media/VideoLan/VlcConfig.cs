namespace HomeAutomations.Client.Services.Media.VideoLan;

public record VlcConfig
{
	public string BaseUrl { get; init; }
	public string Password { get; init; }
}
