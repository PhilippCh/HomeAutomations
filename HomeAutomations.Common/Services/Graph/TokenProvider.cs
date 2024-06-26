// Licensed under the MIT License.

using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensions.Msal;
using Microsoft.Kiota.Abstractions.Authentication;

namespace HomeAutomations.Common.Services.Graph;

public class TokenProvider : IAccessTokenProvider
{
	private readonly Action<string?> _deviceCodeRequestCallback;
	private readonly IPublicClientApplication publicClientApplication;

	public TokenProvider(string clientId, string tenantId, Action<string?> deviceCodeRequestCallback)
	{
		_deviceCodeRequestCallback = deviceCodeRequestCallback;
		publicClientApplication = PublicClientApplicationBuilder
			.Create(clientId)
			.WithTenantId(tenantId)
			.Build();
		AllowedHostsValidator = new AllowedHostsValidator();

		// Building StorageCreationProperties
		var storageProperties = new StorageCreationPropertiesBuilder("msal.homeautomations.cache", "/data/msal")
			.WithLinuxUnprotectedFile()
			.Build();

		// This hooks up the cross-platform cache into MSAL
		var cacheHelper = CreateCacheHelper(storageProperties).Result; //await MsalCacheHelper.CreateAsync(storageProperties);
		cacheHelper.RegisterCache(publicClientApplication.UserTokenCache);
	}

	public async Task ClearCacheAsync()
	{
		var accounts3 = await publicClientApplication.GetAccountsAsync().ConfigureAwait(false);
		foreach (var acc in accounts3)
		{
			Console.WriteLine($"Removing account for {acc.Username}");
			Console.Write(Environment.NewLine);
			await publicClientApplication.RemoveAsync(acc).ConfigureAwait(false);
		}
	}

	public async Task<string> GetAuthorizationTokenAsync(
		Uri uri,
		Dictionary<string, object> additionalAuthenticationContext = default,
		CancellationToken cancellationToken = default)
	{
		var scopes = new[] { "User.Read" };

		try
		{
			var accounts = await publicClientApplication.GetAccountsAsync();

			// Try to acquire an access token from the cache. If an interaction is required,
			// MsalUiRequiredException will be thrown.
			var result = await publicClientApplication.AcquireTokenSilent(scopes, accounts.FirstOrDefault()).ExecuteAsync(cancellationToken);

			return await Task.FromResult(result.AccessToken);
		}
		catch (MsalUiRequiredException)
		{
			// Acquiring an access token interactively. MSAL will cache it, so we can use AcquireTokenSilent
			// on future calls.
			var result1 = await publicClientApplication.AcquireTokenWithDeviceCode(
					scopes, deviceCodeResult =>
					{
						// This will print the message on the console which tells the user where to go sign-in using
						// a separate browser and the code to enter once they sign in.
						// The AcquireTokenWithDeviceCode() method will poll the server after firing this
						// device code callback to look for the successful login of the user via that browser.
						// This background polling (whose interval and timeout data is also provided as fields in the
						// deviceCodeCallback class) will occur until:
						// * The user has successfully logged in via browser and entered the proper code
						// * The timeout specified by the server for the lifetime of this code (typically ~15 minutes) has been reached
						// * The developing application calls the Cancel() method on a CancellationToken sent into the method.
						//   If this occurs, an OperationCanceledException will be thrown (see catch below for more details).
						Console.WriteLine($"Waiting on user device code authentication with code {deviceCodeResult.UserCode} ...");

						// Push the currently requested device code to the Home Assistant frontend.
						_deviceCodeRequestCallback(deviceCodeResult.UserCode);

						return Task.FromResult(0);
					})
				.ExecuteAsync(cancellationToken);

			// Push null to indicate in the Home Assistant frontend that currently there's no further user action required.
			_deviceCodeRequestCallback(null);

			// get the token and return it in your own way
			return await Task.FromResult(result1.AccessToken);
		}
	}

	public AllowedHostsValidator AllowedHostsValidator { get; }

	private static async Task<MsalCacheHelper> CreateCacheHelper(StorageCreationProperties storageProperties) => await MsalCacheHelper.CreateAsync(storageProperties);
}
