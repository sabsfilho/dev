using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAPIMVCLab01.Models;

namespace WebAPIMVCLab01.Controllers;

public class SoccerTeamManagerController : Controller
{
    private readonly ILogger<SoccerTeamManagerController> _logger;

    public SoccerTeamManagerController(ILogger<SoccerTeamManagerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Route("SoccerTeamManager/TeamsByCountry/{country}")]
    [HttpGet]
    public string GetTeamsByCountry(string country)
    {
        using (var client = new HttpClient())
        {
            country = "bra";
            var x = client.GetStringAsync($"https://psychic-barnacle-px56gvvpvv6c94x6-5229.app.github.dev/teamsbycountry/{country}");
            x.Wait();
            return x.Result;
        }
    }
}
