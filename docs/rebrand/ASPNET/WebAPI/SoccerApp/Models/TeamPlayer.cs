namespace SoccerApp.Models;
public class TeamPlayer{
    public int TeamId { get; set;}   
    public int[]? PlayerIds { get; set;}
    internal Player[]? Players { get; set; }

}