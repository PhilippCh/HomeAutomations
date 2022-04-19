using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Counters;

public abstract class BaseCounter<T, TConfig> : BaseAutomation<T, TConfig>
	where T : BaseAutomation<T, TConfig>
	where TConfig : CounterConfig, new()
{
	private readonly IMqttEntityManager _entityManager;

	public BaseCounter(BaseAutomationDependencyAggregate<T, TConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		StartResetSchedule();
		await CreateEntities();

		Context.Events.GetDataEvents(Config.Events.AddEventId).Subscribe(OnAdd);
		Context.Events.GetDataEvents(Config.Events.SetTargetEventId).Subscribe(OnSetTarget);
	}

	private async Task CreateEntities()
	{
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			await _entityManager.CreateAsync(GetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "for", name));
			await _entityManager.CreateAsync(GetTargetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "target for", name));
		}
	}

	private async void StartResetSchedule()
	{
		await CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);
	}

	private async void ResetCounter()
	{
		Logger.Information("Resetting daily {name} counters.", Config.Name);
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			await _entityManager.SetStateAsync(GetEntityId(name), 0.ToString());
		}
	}

	private void OnSetTarget(HaEvent e)
	{
		var targetAmount = e.GetData<int?>(Config.Events.AmountProperty);
		var user = e.GetData<string>(Config.Events.UserProperty);

		if (targetAmount == null || user == null)
		{
			return;
		}

		_entityManager.SetStateAsync(GetTargetEntityId(user), targetAmount.Value.ToString());
	}

	private void OnAdd(HaEvent e)
	{
		var increment = e.GetData<int?>(Config.Events.AmountProperty);
		var user = e.GetData<string>(Config.Events.UserProperty);

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
