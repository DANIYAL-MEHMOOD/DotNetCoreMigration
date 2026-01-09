using Demo.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _service.GetUsersAsync();
        return Ok(users);
    }
}
