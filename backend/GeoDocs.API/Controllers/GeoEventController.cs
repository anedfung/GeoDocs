using GeoDocs.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeoDocs.API.Controllers;

[ApiController]
// [Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly ILogger<EventController> _logger;

    public EventController(ILogger<EventController> logger)
    {
        _logger = logger;
    }

    [HttpGet("events")]
    public IEnumerable<GeoEvent> Get()
    {
        return [];
    }

    [HttpGet("events/{id}")]
    public GeoEvent Get(int id)
    {
        return new GeoEvent();
    }

    [HttpPost("events")]
    public void Post([FromBody]GeoEvent geoEvent)
    {
        return;
    }

    [HttpPatch("events/{id}")]
    public void Patch([FromBody]GeoEvent geoEvent)
    {
        return;
    }

    [HttpDelete("events/{id}")]
    public void Delete(int id)
    {
        return;
    }
}