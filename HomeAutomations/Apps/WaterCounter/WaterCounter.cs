using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.WaterCounter;

public class WaterCounter : BaseAutomation<WaterCounter, WaterCounterConfig>
{
	private const string AddWaterEventId = "water_add_event";
	private const string SetTargetEventId = "water_set_target_event";
	private const string UserProperty = "user";
	private const string AmountProperty = "amount";

	private readonly IMqttEntityManager _entityManager;

	public WaterCounter(BaseAutomationDependencyAggregate<WaterCounter, WaterCounterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		StartResetSchedule();
		await CreateEntities();

		Context.Events.GetDataEvents(AddWaterEventId).Subscribe(OnAddWater);
		Context.Events.GetDataEvents(SetTargetEventId).Subscribe(OnSetTarget);
	}

	private async Task CreateEntities()
	{
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			await _entityManager.CreateAsync(GetEntityId(name), $"Daily water intake for {name}");
			await _entityManager.CreateAsync(GetTargetEntityId(name), $"Daily water intake target for {name}");
		}
	}

	private async void StartResetSchedule()
	{
		await CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);
	}

	private void ResetCounter()
	{
		Logger.Information("Resetting daily water counters.");
		//Config.Counter.SetValue(0);
	}

	private void OnSetTarget(HaEvent e)
	{
		var targetAmount = e.GetData<int?>(AmountProperty);
		var user = e.GetData<string>(UserProperty);

		if (targetAmount == null || user == null)
		{
			return;
		}

		_entityManager.SetStateAsync(GetTargetEntityId(user), targetAmount.Value.ToString());
	}

	private void OnAddWater(HaEvent e)
	{
		var increment = e.GetData<int?>(AmountProperty);
		var user = e.GetData<string>(UserProperty);

		if (increment == null || user == null)
		{
			return;
		}

		if (!int.TryParse(new Entity(Context, GetEntityId(user)).State, out var currentAmount))
		{
			currentAmount = 0;
		}

		_entityManager.SetStateAsync(GetEntityId(user), (currentAmount + increment.Value).ToString());
	}

	private string GetEntityId(string person) => $"{Config.EntityPrefix}{person}";

	private string GetTargetEntityId(string person) => $"{GetEntityId(person)}_target";
}
