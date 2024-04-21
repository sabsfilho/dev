using SoccerApp.Handlers;
using SoccerApp.Models;

namespace SoccerApp.TeamController;
public class TeamController{
    public static IEnumerable<Team> GetTeamsByCountry(string country){
        return TeamHandler.LoadTeams(country);
    }
}