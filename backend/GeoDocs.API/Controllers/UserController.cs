using GeoDocs.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeoDocs.API.Controllers;

[ApiController]
// [Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("users/{id}")]
    public User Get(int id)
    {
        return new User();
    }

    [HttpGet("users/me")]
    public User GetCurrentUser()
    {
        return new User();
    }

    [HttpPost("auth/signup")]
    public void SignUp([FromBody]User user)
    {
        return;
    }

    [HttpPost("auth/login")]
    public void Login([FromBody]User user)
    {
        return;
    }
}