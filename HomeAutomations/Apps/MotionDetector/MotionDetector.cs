using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Common.Services;
using HomeAutomations.Models;
using HomeAutomations.Services;
using NetDaemon.HassModel.Entities;

namespace HomeAutomations.Apps.MotionDetector;

[Focus]
public class MotionDetector : BaseAutomation<MotionDetector, MotionDetectorConfig>
{
	private readonly NotificationService _notificationService;
	private readonly MqttService _mqttService;

	public MotionDetector(BaseAutomationDependencyAggregate<MotionDetector, MotionDetectorConfig> aggregate, NotificationService notificationService, MqttService mqttService)
		: base(aggregate)
	{
		_notificationService = notificationService;
		_mqttService = mqttService;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		(await _mqttService.GetBinaryMessagesForTopic(Config.ImageTopic)).Subscribe(OnImageReceived);
	}

	private async void OnImageReceived(byte[] data)
	{
		if (Config.EnableEntity.IsOff())
		{
			return;
		}

		var image = Image.FromStream(new MemoryStream(data));
		image.Save($"{Config.ImagePath}/motion.jpg", ImageFormat.Jpeg);

		await Task.Delay(500);

		_notificationService.SendNotification(Config.Notification with { Template = Config.Notification.RenderTemplate(Config.Name!) });
	}
}
