namespace SoccerApp.Models;
public class TeamPlayer{
    public int TeamId { get; set;}   
    public List<int>? PlayerIds { get; set;}
    internal Player[]? Players { get; set; }

}