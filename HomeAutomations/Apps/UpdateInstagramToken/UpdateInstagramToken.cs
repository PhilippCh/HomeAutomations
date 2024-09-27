using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Services;
using Renci.SshNet;

namespace HomeAutomations.Apps.UpdateInstagramToken;

public class UpdateInstagramToken(BaseAutomationDependencyAggregate<UpdateInstagramToken, UpdateInstagramTokenConfig> aggregate, INotificationService notificationService)
	: BaseAutomation<UpdateInstagramToken, UpdateInstagramTokenConfig>(aggregate)
{
	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		CronjobExtensions.ScheduleJob(Config.UpdateCrontab, UpdateToken, true, cancellationToken);

		return Task.CompletedTask;
	}

	private async void UpdateToken()
	{
		Logger.Information("Refreshing instagram token");

		try
		{
			var client = new HttpClient();
			var response = await client.GetAsync($"{Config.BaseUrl}?grant_type=ig_refresh_token&access_token={Config.Token}");

			var connectionInfo = new ConnectionInfo(Config.Host, Config.Username, new PasswordAuthenticationMethod(Config.Username, Config.Password));

			using var sftpClient = new SftpClient(connectionInfo);

			sftpClient.Connect();
			sftpClient.UploadFile(await response.Content.ReadAsStreamAsync(), Config.FilePath);
		}
		catch (HttpRequestException ex)
		{
			notificationService.SendNotification(Config.FailureNotification, ex.Message);
		}
	}
}
