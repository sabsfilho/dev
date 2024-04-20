using SoccerApp.Handlers;
using SoccerApp.Models;

namespace SoccerApp.TeamController;
public class TeamController{
    public static IEnumerable<Team> GetTeamsByCountry(string country){
        return TeamHandler.LoadTeams(country);
        /*
        return
            Enumerable.Range(1, 5).Select(index =>
                new Team()
                {
                    Id = Random.Shared.Next(1, 55),
                    Name = country,
                    CountryCode = country.Substring(0,2).ToLower()
                })
                .ToArray();*/
    }
}