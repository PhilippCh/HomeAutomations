using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Extensions;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.Counters;

public abstract class BaseCounter<T, TConfig>(BaseAutomationDependencyAggregate<T, TConfig> aggregate, IMqttEntityManager entityManager)
	: BaseAutomation<T, TConfig>(aggregate)
	where T : BaseAutomation<T, TConfig>
	where TConfig : CounterConfig, new()
{
	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await CreateEntitiesAsync();

		CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounterAsync, cancellationToken: CancellationToken.None);

		Context.Events.GetDataEvents(Config.Events.AddEventId).SubscribeAsync(OnAddAsync);
		Context.Events.GetDataEvents(Config.Events.SetTargetEventId).SubscribeAsync(OnSetTargetAsync);

		Config.Button?.Sensor.StateChanges().SubscribeAsync(async s => await OnButtonPressedAsync(s.New?.State));
	}

	private async Task CreateEntitiesAsync()
	{
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var name = person.GetName();
			await entityManager.CreateAsync(GetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "for", name));
			await entityManager.CreateAsync(GetTargetEntityId(name), string.Join(' ', Config.EntityDescriptionPrefix, "target for", name));
		}
	}

	private async Task ResetCounterAsync()
	{
		Logger.Information("Resetting daily {Name} counters", Config.Name);
		var persons = Context.GetAllEntities("person");

		foreach (var person in persons)
		{
			var entityId = GetEntityId(person.GetName());
			await entityManager.SetStateAsync(entityId, 0.ToString());
			await entityManager.SetAttributesAsync(entityId, new { last_increment = 0 });
		}
	}

	private async Task OnButtonPressedAsync(string? state)
	{
		if (Config.Button == null)
		{
			Logger.Warning("Button config was null, this should never happen in {Name}", nameof(OnButtonPressedAsync));

			return;
		}

		var action = WirelessSwitchActions.Map(state);

		// For every non-special action, increase counter by X.
		if (action != ButtonAction.Undefined && action < ButtonDeviceMessage.SpecialActionBegin)
		{
			await OnAddAsync((int) action, Config.Button.AssociatedUser);
		}

		// Decrease count by 1.
		if (action == ButtonAction.Hold)
		{
			await OnAddAsync(-1, Config.Button.AssociatedUser);
		}
	}

	private async Task OnSetTargetAsync(HaEvent e)
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

		await entityManager.SetStateAsync(GetTargetEntityId(user), targetAmount.ToString(CultureInfo.InvariantCulture));
	}

	private async Task OnAddAsync(HaEvent e)
	{
		var incrementString = e.GetData<string?>(Config.Events.AmountProperty) ?? "";
		var user = e.GetData<string>(Config.Events.UserProperty);

		if (!float.TryParse(incrementString, out var increment))
		{
			increment = 0;
		}

		await OnAddAsync(increment, user);
	}

	private async Task OnAddAsync(float? increment, string? user)
	{
		if (increment == null || user == null)
		{
			return;
		}

		var entityId = GetEntityId(user);
		var newAmount = GetCurrentAmount(user) + increment.Value;
		await entityManager.SetStateAsync(entityId, string.Format(CultureInfo.InvariantCulture, "{0:0.00}", newAmount));
		await entityManager.SetAttributesAsync(entityId, new { last_increment = increment });
	}

	private string GetEntityId(string user) => $"{Config.EntityPrefix}{user}";

	private string GetTargetEntityId(string user) => $"{GetEntityId(user)}_target";

	private float GetCurrentAmount(string user) => GetAmount(GetEntityId(user));

	private float GetAmount(string entityId)
	{
		return float.TryParse(new Entity(Context, entityId).State, CultureInfo.InvariantCulture, out var amount) ? amount : 0;
	}
}
