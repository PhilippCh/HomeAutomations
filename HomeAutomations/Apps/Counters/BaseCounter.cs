using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
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
		await CreateEntities();

		CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);

		Context.Events.GetDataEvents(Config.Events.AddEventId).Subscribe(OnAdd);
		Context.Events.GetDataEvents(Config.Events.SetTargetEventId).Subscribe(OnSetTarget);

		Config.Button?.Sensor.StateChanges().Subscribe(s => OnButtonPressed(s.New?.State));
	}

#pragma warning disable VSTHRD200
	private async Task CreateEntities()
#pragma warning restore VSTHRD200
	{
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			await _entityManager.CreateAsync(GetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "for", name));
			await _entityManager.CreateAsync(GetTargetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "target for", name));
		}
	}

	private async void ResetCounter()
	{
		Logger.Information("Resetting daily {Name} counters", Config.Name);
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var entityId = GetEntityId(person.GetName());
			await _entityManager.SetStateAsync(entityId, 0.ToString());
			await _entityManager.SetAttributesAsync(entityId, new { last_increment = 0 });
		}
	}

	private async void OnButtonPressed(string? state)
	{
		if (Config.Button == null)
		{
			Logger.Warning("Button config was null, this should never happen in {Name}", nameof(OnButtonPressed));

			return;
		}

		var action = WirelessSwitchActions.Map(state);

		// For every non-special action, increase counter by X.
		if (action != ButtonAction.Undefined && action < ButtonDeviceMessage.SpecialActionBegin)
		{
			await OnAdd((int) action, Config.Button.AssociatedUser);
		}

		// Decrease count by 1.
		if (action == ButtonAction.Hold)
		{
			await OnAdd(-1, Config.Button.AssociatedUser);
		}
	}

	private async void OnSetTarget(HaEvent e)
	{
		var targetAmountString = e.GetData<string?>(Config.Events.AmountProperty) ?? "";
		var user = e.GetData<string>(Config.Events.UserProperty);

		if (user == null)
		{
			return;
		}

		if (!float.TryParse(targetAmountString, out var targetAmount))
		{
			targetAmount = 0;
		}

		await _entityManager.SetStateAsync(GetTargetEntityId(user), targetAmount.ToString(CultureInfo.InvariantCulture));
		SendAlerts(user);
	}

	private async void OnAdd(HaEvent e)
	{
		var incrementString = e.GetData<string?>(Config.Events.AmountProperty) ?? "";
		var user = e.GetData<string>(Config.Events.UserProperty);

		if (!float.TryParse(incrementString, out var increment))
		{
			increment = 0;
		}

		await OnAdd(increment, user);
	}

	private async Task OnAdd(float? increment, string? user)
	{
		if (increment == null || user == null)
		{
			return;
		}

		var entityId = GetEntityId(user);
		var newAmount = GetCurrentAmount(user) + increment.Value;
		await _entityManager.SetStateAsync(entityId, string.Format(CultureInfo.InvariantCulture, "{0:0.00}", newAmount));
		await _entityManager.SetAttributesAsync(entityId, new { last_increment = increment });
		SendAlerts(user);
	}

	private void SendAlerts(string user)
	{
		var alertAttributes = new Entity(Context, GetAlertEntityId(user)).Attributes;
	}

	private string GetEntityId(string user) => $"{Config.EntityPrefix}{user}";

	private string GetTargetEntityId(string user) => $"{GetEntityId(user)}_target";

	private string GetAlertEntityId(string user) => $"{GetEntityId(user)}_alert_sent";

	private float GetCurrentAmount(string user) => GetAmount(GetEntityId(user));

	private float GetAmount(string entityId)
	{
		return float.TryParse(new Entity(Context, entityId).State, CultureInfo.InvariantCulture, out var amount) ? amount : 0;
	}
}
