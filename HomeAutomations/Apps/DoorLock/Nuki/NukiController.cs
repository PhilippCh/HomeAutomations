using Microsoft.AspNetCore.Mvc;

namespace HomeAutomations.Apps.DoorLock.Nuki;

[ApiController]
[Route("[controller]/[action]")]
public class NukiController
{
	[HttpPost]
	public string ProcessCallback([FromBody] string callback)
	{
		return "test";
	}
}
