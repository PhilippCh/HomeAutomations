using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace HomeAutomations.Apps.ComputerSwitches;

public class WakeOnLanService
{
	private readonly IHaContext _context;
    private readonly HttpClient _httpClient;
    private readonly ILogger<WakeOnLanService> _logger;
    private readonly AvailabilityCheckConfig _availabilityCheckConfig;

    public WakeOnLanService(
	    IHaContext context,
	    HttpClient httpClient,
        IOptions<AvailabilityCheckConfig> availabilityCheckConfig,
	    ILogger<WakeOnLanService> logger)
    {
	    _context = context;
        _httpClient = httpClient;
        _logger = logger;
        _availabilityCheckConfig = availabilityCheckConfig.Value;
    }

    public async Task<bool> WaitUntilAvailableAsync(string host, string mac)
    {
        Wake(mac);
        return await WaitUntilAvailableInternalAsync(host);
    }

    private async Task<bool> WaitUntilAvailableInternalAsync(string host)
    {
        try
        {
            var result = await _httpClient.GetAsync(GetHostApiUrl(host));

            return result.StatusCode == HttpStatusCode.NotFound;
        }
        catch (Exception ex)
        {
	        _logger.LogError(ex, "An error happened during WaitUntilAvailableInternalAsync");
	        return false;
        }
    }

    private string GetHostApiUrl(string host, string? endpoint = default) =>
        $"http://{host}:{_availabilityCheckConfig.Port}/api{endpoint ?? string.Empty}";

    private void Wake(string macAddress)
    {
	    _context.CallService("wake_on_lan", "send_magic_packet",data: new { mac = macAddress });
    }
}
