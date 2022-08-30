using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.MotionDetector;

public record MotionDetectorConfig : Config
{
	public string? Name { get; init; }
	public string? ImageTopic { get; init; }
	public string? ImagePath { get; init; }
	public InputBooleanEntity EnableEntity { get; init; }
	public Notification Notification { get; init; }
}
