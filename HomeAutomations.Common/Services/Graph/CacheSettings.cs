using Microsoft.Identity.Client.Extensions.Msal;

namespace HomeAutomations.Common.Services.Graph;

public static class CacheSettings
{
	private static readonly string _cacheFilePath = Path.Combine(MsalCacheHelper.UserRootDirectory, "msal.contoso.cache");

	public static readonly string CacheFileName = Path.GetFileName(_cacheFilePath);
	public static readonly string CacheDirectory = Path.GetDirectoryName(_cacheFilePath);
}
