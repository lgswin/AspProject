using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomQuotes.Models;
using RandomQuotes.Services;

namespace RandomQuotes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    /* 
        Then add a reference to the service interface as a private data field in the Home Controller
        and in the constructor accept one as an arg and simply assign it to the private field
    */
    private IQuoteService _quoteService;

    public HomeController(IQuoteService quoteService, ILogger<HomeController> logger)
    {
        _quoteService = quoteService;
        _logger = logger;
    }

    /* 
        In the Home Controller's Index action use the private data field referencing the service
        to generate a Quote and pass the return value off to the view
    */
    public IActionResult Index()
    {
        Quote quote = _quoteService.GetRandomQuote();
        return View("Index", quote);
    }

    /*
        I made "Other" action to call other page.
        In that OtherPage action method, as with the Index action, use the service to generate a new random Quote and pass it off to the view
    */
    public IActionResult Other()
    {
        Quote quote = _quoteService.GetRandomQuote();
        return View("Other", quote);
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

