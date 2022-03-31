using HomeAutomations.Client.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAutomations.Client.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class CommandController : ControllerBase
{
    private readonly CommandParser _commandParser;

    public CommandController(CommandParser commandParser)
    {
        _commandParser = commandParser;
    }
        
    [HttpGet]
    [Route("{name}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ExecuteCommand(string name)
    {
        var command = _commandParser.Get(name);

        if (command == null)
        {
            return NotFound($"No command found '{name}'.");
        }
            
        await command.ExecuteAsync();
        return Ok($"Executed command '{name}'.");

    }
}