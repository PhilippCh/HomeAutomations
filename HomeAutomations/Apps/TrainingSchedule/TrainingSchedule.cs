using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Common.Models;
using HomeAutomations.Common.Services;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated.HomeAutomation;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Integration;

namespace HomeAutomations.Apps.TrainingSchedule;

#pragma warning disable CS8619

public class TrainingSchedule : BaseAutomation<TrainingSchedule, TrainingScheduleConfig>
{
	private MediaStatusMessage? _activeStatusMessage;

	private readonly IMqttEntityManager _entityManager;
	private readonly MqttService _mqttService;

	public TrainingSchedule(BaseAutomationDependencyAggregate<TrainingSchedule, TrainingScheduleConfig> aggregate, IMqttEntityManager entityManager, MqttService mqttService)
		: base(aggregate)
	{
		_entityManager = entityManager;
		_mqttService = mqttService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		Context.RegisterServiceCallBack<TrainingServiceData>("training_start", StartTraining);
		(await _mqttService.GetMessagesForTopic<MediaStatusMessage>(Config.MediaStatusTopic)).Subscribe(e => _activeStatusMessage = e);

		StartScheduleUpdateLoop();
	}

	private async void StartScheduleUpdateLoop()
	{
		await CronjobExtensions.ScheduleJob(Config.UpdateCrontab, UpdateSchedule, true);
	}

	private async void UpdateSchedule()
	{
		var week = DateTime.Today.AsIso8601WeekOfYear() % 2; // To get either 0 or 1 to discern between two fixed schedules.
		var schedules = Config.Schedules.Where(s => s.Week == week).ToList();

		if (schedules.Count != 1)
		{
			Logger.Warning("Invalid number {count} of schedules for week {week}.", schedules.Count, week);

			return;
		}

		var schedule = schedules.First();
		await _entityManager.CreateAsync(Config.EntityId, new EntityCreationOptions("power", Config.EntityId, $"Current training schedule"));
		await _entityManager.SetStateAsync(Config.EntityId, "See entity attributes.");
		await _entityManager.SetAttributesAsync(Config.EntityId, GetEntityAttributes(schedule));
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
		if (_activeStatusMessage == null)
		{
			return;
		}

		var client = new MediaHomeAutomationsClient(_activeStatusMessage.BaseUrl, new HttpClient());
		await client.StartStreamAsync(e.Url);
	}
}
#pragma warning restore CS8619
