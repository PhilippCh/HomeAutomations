using HomeAutomations.Apps.WallPanel.Messages;
using HomeAutomations.Common.Services;
using HomeAutomations.Models.Generated;
using HomeAutomations.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetDaemon.HassModel.Entities;
using ILogger = Serilog.ILogger;

namespace HomeAutomations.Apps.WallPanel;

public class WallPanel
{
	/// <summary>
	/// WARNING: Config is not available in the constructor due to factory usage.
	/// </summary>
	private WallPanelConfig? Config { get; set; }

	/// <summary>
	/// WARNING: Config is not available in the constructor due to factory usage.
	/// </summary>
	private WallPanelMonitorConfig? MonitorConfig { get; set; }

	private readonly MqttService _mqttService;
	private readonly ILogger _logger;

	public WallPanel(MqttService mqttService, ILogger loggerFactory)
	{
		_mqttService = mqttService;
		_logger = loggerFactory.ForContext<WallPanel>();
	}

	public void StartMonitoring()
	{
		StartBatteryMonitoring();
	}

	private async void StartBatteryMonitoring()
	{
		(await _mqttService.GetMessagesForTopic<BatteryMessage>(Config?.BaseTopic, "sensor/battery"))
			.Subscribe(OnBatteryStateChanged);
	}

	private void OnBatteryStateChanged(BatteryMessage? message)
	{
		if (message == null)
		{
			return;
		}

		if ((MonitorConfig?.OffRange.IsSmallerThan(message.Value) ?? false) && (Config?.Switch.IsOff() ?? false))
		{
			StartCharging();
		}

		if ((MonitorConfig?.OffRange.IsLargerThan(message.Value) ?? false) && (Config?.Switch.IsOn() ?? false))
		{
			StopCharging();
		}
	}

	private void StartCharging()
	{
		_logger.Information("{name} charge is < {percentage}%, will turn on power.", Config?.Name, MonitorConfig?.OffRange.Min);
		Config?.Switch.TurnOn();
	}

	private void StopCharging()
	{
		_logger.Information("{name} charge is > {percentage}%, will turn off power.", Config?.Name, MonitorConfig?.OffRange.Max);
		Config?.Switch.TurnOff();
	}

	public class WallPanelFactory
	{
		private readonly IServiceProvider _serviceProvider;

		public WallPanelFactory(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public WallPanel Create(WallPanelMonitorConfig monitorConfig, WallPanelConfig config)
		{
			var panel = (WallPanel) _serviceProvider.GetService(typeof(WallPanel))!;
			panel.MonitorConfig = monitorConfig;
			panel.Config = config;

			return panel;
		}
	}
}
