using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HomeAutomations.Apps.WallPanel.Messages;
using HomeAutomations.Common.Models;
using HomeAutomations.Common.Services;
using HomeAutomations.Extensions;
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
		(await _mqttService.GetMessagesForTopic<FullyKioskDeviceInfoMessage>(MonitorConfig?.Topics.DeviceInfo, Config?.DeviceId))
			.WhereNotNull()
			.Subscribe(OnDeviceInfoChanged);

		(await _mqttService.GetMessagesForChildTopics<MediaStatusMessage>(Config?.MediaCommands.StatusTopic))
			.WhereNotNull()
			.DistinctUntilChanged(m => m.State)
			.Select(
				m => m.State == MediaPlaybackState.NotPlaying //
					? Observable.Return(m).Delay(Config?.MediaCommands.NotPlayingCommandsDelay ?? TimeSpan.Zero)
					: Observable.Return(m))
			.Switch()
			.Subscribe(OnMediaStatusChanged);
	}

	private void OnDeviceInfoChanged(FullyKioskDeviceInfoMessage message)
	{
		CheckBatteryStatus(message);
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

	private void OnMediaStatusChanged(MediaStatusMessage message)
	{
		if (message.State == message.LastState)
		{
			return;
		}

		var commands = message.State == MediaPlaybackState.Playing ? Config?.MediaCommands.PlayingCommands : Config?.MediaCommands.NotPlayingCommands;

		if (commands == null)
		{
			_logger.Warning("No commands found for media playback state {State}", Enum.GetName(typeof(MediaPlaybackState), message.State));

			return;
		}

		SendRemoteApiCommands(commands);
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
