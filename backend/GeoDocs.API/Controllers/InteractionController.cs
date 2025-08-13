using GeoDocs.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeoDocs.API.Controllers;

[ApiController]
// [Route("[controller]")]
public class InteractionController : ControllerBase
{
    private readonly ILogger<InteractionController> _logger;

    public InteractionController(ILogger<InteractionController> logger)
    {
        _logger = logger;
    }

    [HttpGet("events/{id}/interactions")]
    public IEnumerable<Interaction> Get(int id)
    {
        return [];
    }

    [HttpPost("events/{id}/interactions")]
    public void Post([FromRoute]int id, [FromBody]Interaction interaction)
    {
        return;
    }

    [HttpDelete("interactions/{id}")]
    public void Delete(int id)
    {
        return;
    }
}