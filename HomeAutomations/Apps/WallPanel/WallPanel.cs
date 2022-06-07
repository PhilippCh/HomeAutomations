using System.Threading.Tasks;
using HomeAutomations.Apps.WallPanel.Messages;
using HomeAutomations.Common.Services;
using HomeAutomations.Models.Generated;
using NetDaemon.HassModel.Entities;

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

	public async Task StartMonitoringAsync()
	{
		await StartBatteryMonitoringAsync();
	}

	private async Task StartBatteryMonitoringAsync()
	{
		(await _mqttService.GetMessagesForTopic<FullyKioskDeviceInfoMessage>(MonitorConfig?.Topics.DeviceInfo, Config?.DeviceId))
			.Subscribe(OnDeviceInfoChanged);
	}

	private void OnDeviceInfoChanged(FullyKioskDeviceInfoMessage? message)
	{
		if (message == null)
		{
			return;
		}

		if ((MonitorConfig?.OffRange.IsSmallerThan(message.BatteryLevel) ?? false) && (Config?.Switch.IsOff() ?? false))
		{
			StartCharging();
		}

		if ((MonitorConfig?.OffRange.IsLargerThan(message.BatteryLevel) ?? false) && (Config?.Switch.IsOn() ?? false))
		{
			StopCharging();
		}
	}

	private void StartCharging()
	{
		_logger.Information("{Name} charge is < {Percentage}%, will turn on power", Config?.Name, MonitorConfig?.OffRange.Min);
		Config?.Switch.TurnOn();
	}

	private void StopCharging()
	{
		_logger.Information("{Name} charge is > {Percentage}%, will turn off power", Config?.Name, MonitorConfig?.OffRange.Max);
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
