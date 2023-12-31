using Microsoft.AspNetCore.Mvc;
using TennisStats.Api.Models;

namespace TennisStats.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ResultsController : ControllerBase
{
    private readonly ILogger<ResultsController> _logger;

    private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

    public ResultsController(ILogger<ResultsController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Post(MatchResultInputModel result)
    {
        await Task.Delay(Random.Next(250, 500));// Simulates a slow API and network latency

        // this would save to a database

        return NoContent();
    }
}
