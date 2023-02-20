﻿using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
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
	private readonly MqttService _mqttService;

	public BaseCounter(BaseAutomationDependencyAggregate<T, TConfig> aggregate, IMqttEntityManager entityManager, MqttService mqttService)
		: base(aggregate)
	{
		_entityManager = entityManager;
		_mqttService = mqttService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await CreateEntities();

		CronjobExtensions.ScheduleJob(Config.ResetCrontab, ResetCounter, cancellationToken: CancellationToken.None);

		Context.Events.GetDataEvents(Config.Events.AddEventId).Subscribe(OnAdd);
		Context.Events.GetDataEvents(Config.Events.SetTargetEventId).Subscribe(OnSetTarget);

		Config.Button?.Sensor.StateChanges().Subscribe(s => OnButtonPressed(s.New?.State));
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

	private async void ResetCounter()
	{
		Logger.Information("Resetting daily {name} counters.", Config.Name);
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
			Logger.Warning("Button config was null, this should never happen in {name}", nameof(OnButtonPressed));

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

	private void OnSetTarget(HaEvent e)
	{
		var targetAmount = e.GetData<int?>(Config.Events.AmountProperty);
		var user = e.GetData<string>(Config.Events.UserProperty);

		if (targetAmount == null || user == null)
		{
			return;
		}

		_entityManager.SetStateAsync(GetTargetEntityId(user), targetAmount.Value.ToString());
		SendAlerts(user);
	}

	private async void OnAdd(HaEvent e)
	{
		var increment = e.GetData<int?>(Config.Events.AmountProperty);
		var user = e.GetData<string>(Config.Events.UserProperty);

		await OnAdd(increment, user);
	}

	private async Task OnAdd(int? increment, string? user)
	{
		if (increment == null || user == null)
		{
			return;
		}

		var entityId = GetEntityId(user);
		await _entityManager.SetStateAsync(entityId, (GetCurrentAmount(user) + increment.Value).ToString());
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

	private int GetCurrentAmount(string user) => GetAmount(GetEntityId(user));

	private int GetTargetAmount(string user) => GetAmount(GetTargetEntityId(user));

	private int GetAmount(string entityId)
	{
		return int.TryParse(new Entity(Context, entityId).State, out var amount) ? amount : 0;
	}
}
