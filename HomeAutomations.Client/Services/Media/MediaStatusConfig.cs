namespace HomeAutomations.Client.Services.Media;

public record MediaStatusConfig
{
	public string BaseTopic { get; init; }
	public TimeSpan UpdateInterval { get; init; }
	public IEnumerable<MediaPlayerPredicate> SupportedPlayers { get; init; }
}
