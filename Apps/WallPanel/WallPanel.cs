using HomeAutomations.Apps.WallPanel.Messages;
using HomeAutomations.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomations.Apps.WallPanel;

public class WallPanel
{
	/// <summary>
	/// WARNING: Config is not available in the constructor due to factory usage.
	/// </summary>
	private WallPanelConfig? Config { get; set; }

	private readonly MqttService _mqttService;

	public WallPanel(MqttService mqttService)
	{
		_mqttService = mqttService;
	}

	public void StartMonitoring()
	{
		StartBatteryMonitoring();
	}

	private async void StartBatteryMonitoring()
	{
		await _mqttService.GetMessagesForTopic<BatteryMessage>($"{Config?.BaseTopic}sensor/battery");
	}

	public class WallPanelFactory
	{
		private readonly IServiceProvider _serviceProvider;

		public WallPanelFactory(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public WallPanel Create(WallPanelConfig config)
		{
			var panel = (WallPanel) _serviceProvider.GetService(typeof(WallPanel))!;
			panel.Config = config;

			return panel;
		}
	}
}
