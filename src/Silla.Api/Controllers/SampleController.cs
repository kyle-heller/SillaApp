using Microsoft.AspNetCore.Mvc;
using Silla.Shared.Models;

namespace Silla.Api.Controllers;
using Silla.Shared.Models;

[ApiController]
[Route("api/[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEntry()
    {
        var entry = new JournalEntry
        {
            FamilyId = Guid.NewGuid(),
            AuthorId = Guid.NewGuid(),
            Title = "First Test Entry",
            Body = "This is a placeholder entry from the API."
        };
        return Ok(entry);
    }
}

