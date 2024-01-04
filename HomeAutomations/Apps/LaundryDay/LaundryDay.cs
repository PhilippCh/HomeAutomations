using System.Globalization;
using System.Reactive.Concurrency;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using HomeAutomations.Models.Generated;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.LaundryDay;

[Focus]
public class LaundryDay(
	BaseAutomationDependencyAggregate<LaundryDay, LaundryDayConfig> aggregate,
	IMqttEntityManager entityManager,
	BoschShcServices boschShcServices,
	IScheduler scheduler)
	: BaseAutomation<LaundryDay, LaundryDayConfig>(aggregate)
{
	private IDisposable? _schedule;

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await CreateEntityIfNotExistsAsync();
		await StartExistingDryingTimerAsync();

		Config.ButtonEntity.StateChanges()
			.Subscribe(s => OnButtonPressedAsync(s.New?.State));
	}

	private async Task CreateEntityIfNotExistsAsync()
	{
		if (Config.ResetDateSensorEntity.State == null)
		{
			await entityManager.CreateAsync(Config.ResetDateSensorEntity.EntityId, new EntityCreationOptions(UniqueId: Config.ResetDateSensorEntity.EntityId));
			await entityManager.SetStateAsync(Config.ResetDateSensorEntity.EntityId, string.Empty);
		}
	}

	private async Task StartExistingDryingTimerAsync()
	{
		if (DateTime.TryParse(Config.ResetDateSensorEntity.State, out var endDate))
		{
			await StartScenarioWithResetAsync(Config.Scenarios.Drying, endDate);
		}
	}

	private async Task OnButtonPressedAsync(string? state)
	{
		var action = WirelessSwitchActions.Map(state);

		if (action == ButtonAction.BrightnessUp)
		{
			Logger.Information("Resetting scenario to {Scenario}", Config.Scenarios.Default);
			await StartScenarioWithResetAsync(Config.Scenarios.Default, null);

			return;
		}

		if (WirelessSwitchActions.IsPressedAction(state))
		{
			await StartScenarioWithResetAsync(Config.Scenarios.Drying, DateTime.Now.AddDays(1));
		}
	}

	private async Task StartScenarioWithResetAsync(string scenario, DateTime? resetDate)
	{
		Logger.Information("Starting scenario {Scenario} until {ResetDate}", scenario, resetDate);

		boschShcServices.TriggerScenario(scenario);
		await entityManager.SetStateAsync(Config.ResetDateSensorEntity.EntityId, resetDate?.ToString(CultureInfo.InvariantCulture) ?? string.Empty);

		_schedule?.Dispose();

		if (resetDate != null)
		{
			_schedule = scheduler.ScheduleAsync(resetDate.Value, async (_, _) => await StartScenarioWithResetAsync(Config.Scenarios.Default, null));
		}
	}
}
