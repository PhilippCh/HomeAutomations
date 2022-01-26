using System;
using System.Reactive;
using System.Reactive.Linq;
using HomeAssistant.Automations.Apps.KitchenLight;
using HomeAssistant.Automations.Models;
using HomeAssistant.Automations.Models.DeviceMessages;
using HomeAssistant.Automations.Services;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Common;

namespace HomeAssistant.Automations.Apps.Scales.KitchenScale;

[NetDaemonApp]
public class KitchenScale : BaseAutomation<KitchenScale, KitchenScaleConfig>
{
	private readonly MqttService _mqttService;

	public KitchenScale(
		MqttService mqttService,
		BaseAutomationDependencyAggregate<KitchenScale, KitchenScaleConfig> aggregate)
		: base(aggregate)
	{
		_mqttService = mqttService;
	}

	public static IServiceCollection AddServices(IServiceCollection services, IConfiguration config) =>
		services
			.Configure<KitchenLightConfig>(config.GetSection("HomeAutomations:KitchenScale"));

	protected override void Start()
	{
		_mqttService.Connect(GetType().Name, new[] { Config.Topic });
		_mqttService.GetMessagesForTopic<ScaleDeviceMessage>(Config.Topic).Subscribe(OnDeviceMessageReceived);
	}

	private void OnDeviceMessageReceived(ScaleDeviceMessage? message)
	{
		if (message == null)
		{
			return;
		}

		Logger.Information("{value} {unit}", message.Value, message.Unit);
	}
}
