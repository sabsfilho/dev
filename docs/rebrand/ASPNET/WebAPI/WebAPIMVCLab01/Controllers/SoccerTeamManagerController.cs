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
}
