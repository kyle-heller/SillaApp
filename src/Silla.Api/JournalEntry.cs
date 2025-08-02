using Microsoft.AspNetCore.Mvc;

namespace Silla.Api;

public class JournalEntry : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}