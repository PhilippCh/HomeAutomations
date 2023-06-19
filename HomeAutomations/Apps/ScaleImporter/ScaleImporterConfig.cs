using HomeAutomations.Common.Models.Config;

namespace HomeAutomations.Apps.ScaleImporter;

public record ScaleImporterConfig : Config
{
	public string Email { get; init; }
	public string Password { get; init; }
	public TimeSpan UpdateInterval { get; init; }
	public DateTimeOffset ImportStartDate { get; init; }
}
