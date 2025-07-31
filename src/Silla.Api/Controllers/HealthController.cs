using Microsoft.AspNetCore.Mvc;

namespace Silla.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { status = "Silla API is healthy", timestamp = DateTime.UtcNow });
}