using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomations.Entities.Constants;
using HomeAutomations.Models;
using HomeAutomations.Services;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.HassModel.Entities;
using Polly;
using Polly.Retry;
using ObservableExtensions = HomeAutomations.Common.Extensions.ObservableExtensions;

namespace HomeAutomations.Apps.InternetWatchdog;

public class InternetWatchdog : BaseAutomation<InternetWatchdog, InternetWatchdogConfig>
{
	private readonly INotificationService _notificationService;
	private readonly IMqttEntityManager _entityManager;
	private readonly HttpClient _httpClient;

	// ReSharper disable once ConvertToPrimaryConstructor | Primary constructor displays values as null in unit tests.
	public InternetWatchdog(
		BaseAutomationDependencyAggregate<InternetWatchdog, InternetWatchdogConfig> aggregate,
		INotificationService notificationService,
		IMqttEntityManager entityManager,
		HttpClient httpClient)
		: base(aggregate)
	{
		_notificationService = notificationService;
		_entityManager = entityManager;
		_httpClient = httpClient;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await _entityManager.CreateAsync(Config.Check.ResultEntity.EntityId, new EntityCreationOptions(null, Config.Check.ResultEntity.EntityId, "Internet status"));

		Config.Check.ResultEntity.StateChanges()
			.Subscribe(x => OnSensorStateChanged(x.Old?.IsOn(), x.New?.IsOn()));

		ObservableExtensions.Interval(Config.Check.Interval, true)
			.SubscribeAsync(_ => CheckInternetStatusAsync());
	}

	private async Task CheckInternetStatusAsync()
	{
		var pipeline = new ResiliencePipelineBuilder()
			.AddRetry(
				new RetryStrategyOptions
				{
					Delay = TimeSpan.FromSeconds(15),
					BackoffType = DelayBackoffType.Exponential
				})
			.Build();

		try
		{
			await pipeline.ExecuteAsync(
				async x =>
				{
					var response = await _httpClient.GetAsync(Config.Check.Host, x);
					response.EnsureSuccessStatusCode();

					await SetInternetAvailabilitySensorAsync(true);
				});
		}
		catch (HttpRequestException ex)
		{
			await SetInternetAvailabilitySensorAsync(false, ex);
		}
	}

	private async Task SetInternetAvailabilitySensorAsync(bool isAvailable, HttpRequestException? ex = default)
	{
		await _entityManager.SetStateAsync(Config.Check.ResultEntity.EntityId, isAvailable ? EntityStates.On : EntityStates.Off);
		await _entityManager.SetAttributesAsync(Config.Check.ResultEntity.EntityId, new { Error = ex?.Message ?? string.Empty });
	}

	private void OnSensorStateChanged(bool? oldState, bool? newState)
	{
		if (newState == null)
		{
			return;
		}

		if (oldState != newState && !newState.Value)
		{
			// Internet is down, send notification.
			_notificationService.SendNotification(Config.InternetDownNotification);
		}

		if (oldState != newState && newState.Value && !(oldState ?? true))
		{
			// Internet is back up, send notification.
			_notificationService.SendNotification(Config.InternetUpNotification);
		}
	}
}
