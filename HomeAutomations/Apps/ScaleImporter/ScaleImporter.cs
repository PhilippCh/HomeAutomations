using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Apps.ScaleImporter.VeSync;
using HomeAutomations.Models;
using NetDaemon.Extensions.MqttEntityManager;
using ObservableExtensions = NetDaemon.HassModel.ObservableExtensions;

namespace HomeAutomations.Apps.ScaleImporter;

[Focus]
public class ScaleImporter : BaseAutomation<ScaleImporter, ScaleImporterConfig>
{
	private readonly IMqttEntityManager _entityManager;
	private readonly VeSyncApiClient _apiClient;

	public ScaleImporter(BaseAutomationDependencyAggregate<ScaleImporter, ScaleImporterConfig> aggregate, IMqttEntityManager entityManager)
		: base(aggregate)
	{
		_entityManager = entityManager;
		_apiClient = new VeSyncApiClient(Config.Email, Config.Password);
	}

	protected override Task StartAsync(CancellationToken cancellationToken)
	{
		Observable.Interval(Config.UpdateInterval)
			.StartWith(0)
			.Subscribe(_ => UpdateScaleValues());

		return Task.CompletedTask;
	}

	private async void UpdateScaleValues()
	{
		var userData = await _apiClient.LoginAsync();

		if (userData == null)
		{
			return;
		}

		var devices = await _apiClient.GetDevicesAsync(userData);

		if (devices.List.Length == 0)
		{
			return;
		}

		foreach (var device in devices.List)
		{
			var subUsers = await _apiClient.GetAllSubUsersAsync(userData, device.ConfigModule);
			var weightData = await _apiClient.GetWeightDataAsync(userData, devices.List.First(), Config.ImportStartDate);
		}
	}
}

