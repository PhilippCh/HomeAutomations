using System.Collections.Generic;
using System.Net.Http;
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

	private FullyKioskDeviceInfoMessage? _lastMessage;

	public WallPanel(MqttService mqttService, ILogger loggerFactory)
	{
		_mqttService = mqttService;
		_logger = loggerFactory.ForContext<WallPanel>();
	}

	public async Task StartMonitoringAsync()
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

		CheckBatteryStatus(message);
		CheckPluggedStatus(message);

		_lastMessage = message;
	}

	private void CheckBatteryStatus(FullyKioskDeviceInfoMessage message)
	{
		if ((MonitorConfig?.OffRange.IsSmallerThan(message.BatteryLevel) ?? false) && (Config?.Switch.IsOff() ?? false))
		{
			_logger.Information("{Name} charge is < {Percentage}%, will turn on power", Config?.Name, MonitorConfig?.OffRange.Min);
			Config?.Switch.TurnOn();
		}

		if ((MonitorConfig?.OffRange.IsLargerThan(message.BatteryLevel) ?? false) && (Config?.Switch.IsOn() ?? false))
		{
			_logger.Information("{Name} charge is > {Percentage}%, will turn off power", Config?.Name, MonitorConfig?.OffRange.Max);
			Config?.Switch.TurnOff();
		}
	}

	private void CheckPluggedStatus(FullyKioskDeviceInfoMessage message)
	{
		if (_lastMessage == null)
		{
			// This can only be performed by comparing current to last device state, so we need both.
			_logger.Information("No last wall panel message");
			return;
		}

		if (Config?.PluggedRestCommands != null && message.IsPlugged && !_lastMessage.IsPlugged)
		{
			_logger.Information("Wall panel plugged in, running commands");
			SendRemoteApiCommands(Config.PluggedRestCommands);
		}

		if (Config?.UnpluggedRestCommands != null && !message.IsPlugged && _lastMessage.IsPlugged)
		{
			_logger.Information("Wall panel unplugged, running commands");
			SendRemoteApiCommands(Config.UnpluggedRestCommands);
		}
	}

	private async void SendRemoteApiCommands(IEnumerable<string> commands)
	{
		var client = new HttpClient();

		foreach (var command in commands)
		{
			await client.GetAsync(command);
		}
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
