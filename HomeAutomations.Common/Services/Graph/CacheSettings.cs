using Microsoft.Identity.Client.Extensions.Msal;

namespace HomeAutomations.Common.Services.Graph;

public static class CacheSettings
{
	private static readonly string _cacheFilePath = Path.Combine(MsalCacheHelper.UserRootDirectory, "msal.contoso.cache");

	public static readonly string CacheFileName = Path.GetFileName(_cacheFilePath);
	public static readonly string CacheDirectory = Path.GetDirectoryName(_cacheFilePath);
	
	public static readonly string LinuxKeyRingSchema = "com.contoso.devtools.tokencache";
    public static readonly string LinuxKeyRingCollection = MsalCacheHelper.LinuxKeyRingDefaultCollection;
    public static readonly string LinuxKeyRingLabel = "MSAL token cache for all Contoso dev tool apps.";
    public static readonly KeyValuePair<string, string> LinuxKeyRingAttr1 = new KeyValuePair<string, string>("Version", "1");
    public static readonly KeyValuePair<string, string> LinuxKeyRingAttr2 = new KeyValuePair<string, string>("ProductGroup", "HomeAutomations");
}
