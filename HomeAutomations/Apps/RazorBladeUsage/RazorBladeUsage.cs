using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Models.DeviceMessages;
using NetDaemon.Extensions.MqttEntityManager;

namespace HomeAutomations.Apps.RazorBladeUsage;

public class RazorBladeUsage : BaseAutomation<RazorBladeUsage, RazorBladeUsageConfig>
{
	private readonly MqttService _mqttService;
	private readonly IMqttEntityManager _entityManager;

	public RazorBladeUsage(BaseAutomationDependencyAggregate<RazorBladeUsage, RazorBladeUsageConfig> aggregate, MqttService mqttService, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_mqttService = mqttService;
		_entityManager = entityManager;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		(await _mqttService.GetMessagesForTopic<ButtonDeviceMessage>(Config.CounterTopic)).Subscribe(OnButtonPressed);
		await _entityManager.CreateAsync(Config.Sensor.EntityId, new EntityCreationOptions(null, Config.Sensor.EntityId, $"Razor blade usage"));
	}

	private async void OnButtonPressed(ButtonDeviceMessage? e)
	{
		if (e == null)
		{
			return;
		}

		Func<Task> action = e.Action switch
		{
			ButtonAction.Hold => Reset,
			_ => OnBladeUsed
		};

		await action();
	}

	private async Task OnBladeUsed()
	{
		if (!int.TryParse(Config.Sensor.State, out var count))
		{
			return;
		}

		await _entityManager.SetStateAsync(Config.Sensor.EntityId, (count + 1).ToString());
	}

	private async Task Reset()
	{
		await _entityManager.SetStateAsync(Config.Sensor.EntityId, 0.ToString());
	}
}
