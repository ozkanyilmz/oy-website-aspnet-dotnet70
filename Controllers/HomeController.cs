using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using site.Models;

namespace site.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("/csharp")]
    public IActionResult CSharp()
    {
        return View();
    }

    [Route("/web")]
    public IActionResult Web()
    {
        return View();
    }

    [Route("/database")]
    public IActionResult Database()
    {
        return View();
    }

    [Route("/privacy")]
    public IActionResult Privacy()
    {
        return View();
    }
    
    [Route("/contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
