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
            var x = client.GetStringAsync($"https://soccermanagerapp.azurewebsites.net/teamsbycountry/{country}");
            x.Wait();
            return x.Result;
        }
    }
    [Route("SoccerTeamManager/PlayersByTeam/{team}")]
    [HttpGet]
    public string GetPlayersByTeam(string team)
    {
        using (var client = new HttpClient())
        {
            var x = client.GetStringAsync($"https://soccermanagerapp.azurewebsites.net/playersbyteam/{team}");
            x.Wait();
            return x.Result;
        }
    }
}
