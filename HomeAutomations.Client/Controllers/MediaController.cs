using HomeAutomations.Client.Services.Media;
using HomeAutomations.Common.Models;
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
    [Route("startStream")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult StartStream(string url)
    {
        _mediaControllerService.StartStream(url);
        return Ok();
    }

    [HttpPost]
    [Route("togglePlayback")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult TogglePlayback()
    {
	    _mediaControllerService.TogglePlayback();
	    return Ok();
    }
}
