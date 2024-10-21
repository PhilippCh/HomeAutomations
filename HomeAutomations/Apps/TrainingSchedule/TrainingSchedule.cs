using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.MovieTime;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.TrainingSchedule;

// TODO: Migrate creation of the schedule to a VirtualEntity.
[Focus]
public class TrainingSchedule(
	BaseAutomationDependencyAggregate<TrainingSchedule, TrainingScheduleConfig> aggregate,
	IMqttEntityManager entityManager,
	ActionSequencerService sequencerService)
	: BaseAutomation<TrainingSchedule, TrainingScheduleConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<TrainingServiceData>("start_training", StartTraining);
		CronjobExtensions.ScheduleJob(Config.UpdateCrontab, UpdateSchedule, true, cancellationToken);

		return Task.CompletedTask;
	}

	private async void UpdateSchedule()
	{
		var week = DateTime.Today.AsIso8601WeekOfYear() % 2; // To get either 0 or 1 to discern between two fixed schedules.
		var schedules = Config.Schedules.Where(s => s.Week == week).ToList();

		if (schedules.Count != 1)
		{
			Logger.Warning("Invalid number {Count} of schedules for week {Week}", schedules.Count, week);

			return;
		}

		var schedule = schedules.First();
		await entityManager.CreateAsync(Config.EntityId, new EntityCreationOptions(null, Config.EntityId, "Current training schedule"));
		await entityManager.SetStateAsync(Config.EntityId, "See entity attributes.");
		await entityManager.SetAttributesAsync(Config.EntityId, GetEntityAttributes(schedule));
	}

	private object GetEntityAttributes(ScheduleConfig schedule)
	{
		var attributes = new ExpandoObject();

		foreach (var (training, i) in schedule.Trainings.Select((value, i) => (value, i)))
		{
			var attrDictionary = (IDictionary<string, object>) attributes;
			attrDictionary.Add($"workout{i}_title", training.Title);
			attrDictionary.Add($"workout{i}_url", training.Url);
		}

		return attributes;
	}

	private async void StartTraining(TrainingServiceData e)
	{
		Logger.Information("Starting training session {Url}", e.Url);

		await sequencerService.RunAsync(
			new RunAction(
				() =>
				{
					Context.CallService(
						"netdaemon", "movie_time", data: new MovieTimeServiceData
						{
							AvReceiverSource = "Apple TV"
						});
				}),
			new RunAction(() => Config.MediaPlayer.TurnOn()),
			new RunAction(() => Config.MediaPlayer.PlayMedia(e.Url, "video"), 5000)
		);

		await Task.Delay(TimeSpan.FromSeconds(10));
		Config.Remote.SendCommand(new RemoteSendCommandParameters
		{
			Command = "pause"
		});
	}
}
