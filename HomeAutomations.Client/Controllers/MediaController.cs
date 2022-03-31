using HomeAutomations.Client.Media;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomations.Client.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class MediaController : ControllerBase
{
    private readonly MediaControllerService _mediaControllerService;

    public MediaController(MediaControllerService mediaControllerService)
    {
        _mediaControllerService = mediaControllerService;
    }

    [HttpPost]
    [Route("togglePlayback")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult TogglePlayback([FromBody] IEnumerable<MediaPlayerPredicate> allowedPlayers)
    {
        _mediaControllerService.TogglePlayback(allowedPlayers);
        return Ok();
    }

    [HttpGet]
    [Route("status")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<MediaStatus> GetStatus()
    {
	    return Ok(_mediaControllerService.GetStatus());
    }
}
