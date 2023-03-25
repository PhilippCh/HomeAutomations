using Microsoft.AspNetCore.Mvc;

namespace HomeAutomations.Apps.DoorLock.Nuki;

[ApiController]
public class NukiController
{
	[HttpPost("callback")]
	public string ProcessCallback(NukiCallback callback)
	{
		return "test";
	}
}
