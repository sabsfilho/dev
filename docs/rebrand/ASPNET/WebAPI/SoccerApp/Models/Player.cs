namespace SoccerApp.Models;
public class Player{
    public int Id { get; set;}
    public required string Name { get; set;}
    public string? ShirtName { get; set;}
    public string? Position { get; set;}
    public string? Birth { get; set;}
    public required string CountryCode {get;set;}
    public required string TeamId {get;set;}
    public int Age { get; set;}
    public int Rank { get; set;}
    public int Height { get; set;}
    public int Weight { get; set;}
    public int SquadNumber { get; set;}
    public string? PreferredFoot {get;set;}
    public string? Nationality {get;set;}
    
}