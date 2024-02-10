using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BPMeasurement.Models;
using BPMeasurement.Entities;

namespace BPMeasurement.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;
    private BPDbContext _bpDbContext;

    public HomeController(BPDbContext ctx)
    {
        _bpDbContext = ctx;
    }

    public IActionResult Index()
    {
        var bps = _bpDbContext.BloodPressures.OrderBy(m => m.DateTime).ToList();
        return View(bps);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

