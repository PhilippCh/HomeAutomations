﻿using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using HomeAutomations.Apps.DoorLock.Nuki;
using HomeAutomations.Common.Extensions;
using HomeAutomations.Models;
using HomeAutomations.Models.Generated;

namespace HomeAutomations.Apps.DoorLock;

[Focus]
public class DoorLock : BaseAutomation<DoorLock, DoorLockConfig>
{
	private IDisposable? _rtoTimeoutObserver;

	private readonly HttpClient _httpClient;

	public DoorLock(BaseAutomationDependencyAggregate<DoorLock, DoorLockConfig> aggregate, HttpClient httpClient)
		: base(aggregate)
	{
		_httpClient = httpClient;
	}

	protected override async Task StartAsync(CancellationToken cancellationToken)
	{
		await CreateBridgeCallbacks();

		Context.Events.Filter<EnableRtoEventData>(EnableRtoEventData.Id)
			.SwitchMap(Authenticate)
			.Catch<EnableRtoEventData?, AuthenticationException>(
				ex =>
				{
					Logger.Warning("Authentication error: {Message}", ex.Message);

					return Observable.Empty<EnableRtoEventData>();
				})
			.Subscribe(_ => EnableRingToOpen());
	}

	private async Task CreateBridgeCallbacks()
	{
		var response = await _httpClient.GetFromJsonAsync<CallbackListResponse>(GetBridgeApiCall("callback/list"));

		if (response.Callbacks.Any())
		{
			foreach (var callback in response.Callbacks)
			{
				await _httpClient.GetAsync(
					GetBridgeApiCall(
						"callback/remove", new NameValueCollection
						{
							{ "id", callback.Id.ToString() }
						}));
			}
		}

		var response2 = await _httpClient.GetAsync(
			GetBridgeApiCall(
				"callback/add", new NameValueCollection
				{
					{ "url", Config.BridgeApi.CallbackUrl }
				}));
	}

	private Uri GetBridgeApiCall(string method, NameValueCollection? extraParameters = null)
	{
		var uriBuilder = new UriBuilder($"{Config.BridgeApi.BaseUrl}/{method}");
		var queryParameters = HttpUtility.ParseQueryString(string.Empty);
		queryParameters["token"] = Config.BridgeApi.Token;

		if (extraParameters is not null)
		{
			foreach (string parameter in extraParameters)
			{
				queryParameters[parameter] = extraParameters[parameter];
			}
		}

		uriBuilder.Query = queryParameters.ToString();

		return uriBuilder.Uri;
	}

	private IObservable<EnableRtoEventData?> Authenticate(Event<EnableRtoEventData> e)
	{
		if (e.Data?.Token != Config.Token)
		{
			return Observable.Throw<EnableRtoEventData>(new AuthenticationException($"Token {e.Data?.Token} is not authenticated."));
		}

		return Observable.Return(e.Data);
	}

	private void EnableRingToOpen()
	{
		Config.OpenerEntity.Unlock();

		_rtoTimeoutObserver?.Dispose();
		_rtoTimeoutObserver = Observable.Timer(Config.RtoTimeout).Subscribe(_ => Config.OpenerEntity.Lock());
	}
}