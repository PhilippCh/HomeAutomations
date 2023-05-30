using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using Renci.SshNet;

namespace HomeAutomations.Apps.UpdateInstagramToken;

public class UpdateInstagramToken : BaseAutomation<UpdateInstagramToken, UpdateInstagramTokenConfig>
{
	private readonly NotificationService _notificationService;

	public UpdateInstagramToken(BaseAutomationDependencyAggregate<UpdateInstagramToken, UpdateInstagramTokenConfig> aggregate, NotificationService notificationService)
		: base(aggregate)
	{
		_notificationService = notificationService;
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		CronjobExtensions.ScheduleJob(Config.UpdateCrontab, UpdateToken, true, cancellationToken);

		return Task.CompletedTask;
	}

	private async void UpdateToken()
	{
		try
		{
			var client = new HttpClient();
			var response = await client.GetAsync(Config.Url);

			var connectionInfo = new ConnectionInfo(Config.Target.Host, Config.Target.Username, new PasswordAuthenticationMethod(Config.Target.Username, Config.Target.Password));

			using var sftpClient = new SftpClient(connectionInfo);

			sftpClient.Connect();
			sftpClient.UploadFile(await response.Content.ReadAsStreamAsync(), Config.FilePath);
		}
		catch (HttpRequestException ex)
		{
			_notificationService.SendNotification(Config.FailureNotification with { Template = Config.FailureNotification.RenderTemplate(ex.Message) });
		}
	}
}
