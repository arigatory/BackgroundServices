using Microsoft.AspNetCore.Mvc;
using TennisStats.Api.Models;

namespace TennisStats.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StatsController : ControllerBase
{
    private readonly ILogger<StatsController> _logger;

    private static readonly Random Random = new Random((int)DateTime.Now.Ticks);

    public StatsController(ILogger<StatsController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Post(PlayerStatInputModel stat)
    {
        await Task.Delay(Random.Next(250, 500));// Simulates a slow API and network latency

        return NoContent();
    }
}
