using System.Collections.Generic;
using HomeAutomations.Common.Models.Config;
using HomeAutomations.Models.Generated;

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
	public MediaPlayerEntity MediaPlayer { get; init; }
	public RemoteEntity Remote { get; init; }
	public IEnumerable<ScheduleConfig> Schedules { get; init; }
}
