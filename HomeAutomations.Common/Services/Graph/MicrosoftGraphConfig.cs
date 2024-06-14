namespace HomeAutomations.Common.Services.Graph;

public record MicrosoftGraphConfig
{
	public string TenantId { get; init; }
	public string ClientId { get; init; }
}
