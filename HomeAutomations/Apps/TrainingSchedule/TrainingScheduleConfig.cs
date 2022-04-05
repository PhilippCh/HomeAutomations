using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;

namespace HomeAutomations.Apps.TrainingSchedule;

public record TrainingConfig
{
	public string Title { get; init; }
	public string Url { get; init; }
}

public record ScheduleConfig
{
	public int Week { get; init; }
	public IEnumerable<TrainingConfig> Trainings { get; init; }
}

public record TrainingScheduleConfig : Config
{
	public string UpdateCrontab { get; init; }
	public string EntityId { get; init; }
	public IEnumerable<ScheduleConfig> Schedules { get; init; }
}
