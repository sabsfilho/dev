using SoccerApp.Handlers;
using SoccerApp.Models;

namespace SoccerApp.PlayerController;
public class PlayerController{
    public static Player GetPlayer(string country, string playerId){
        return PlayerHandler.LoadPlayer(country, playerId);
    }
    public static IEnumerable<Player> GetPlayersByTeam(string country, string teamId){
        return TeamPlayerHandler.LoadTeamPlayers(country, teamId);
    }
}