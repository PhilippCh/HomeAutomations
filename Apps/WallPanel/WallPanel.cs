using HomeAutomations.Apps.WallPanel.Messages;
using HomeAutomations.Services;

namespace HomeAutomations.Apps.WallPanel;

public class WallPanelFactory
{
	private readonly IServiceProvider _serviceProvider;

	public WallPanelFactory(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	public WallPanel Create(WallPanelConfig config) => (WallPanel)_serviceProvider.GetService(typeof(WallPanel))!;
}

public class WallPanel
{
	private readonly WallPanelConfig _config;
	private readonly MqttService _mqttService;

	public WallPanel(WallPanelConfig config, MqttService mqttService)
	{
		_config = config;
		_mqttService = mqttService;
	}

	public void StartMonitoring()
	{
		StartBatteryMonitoring();
	}

	private async void StartBatteryMonitoring()
	{
		await _mqttService.GetMessagesForTopic<BatteryMessage>("sensor/battery");
	}
}
