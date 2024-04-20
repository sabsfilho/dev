namespace SoccerApp.Models;
public class Team{
    public int Id { get; set;}
    public required string Name { get; set;}
    public required string CountryCode {get;set;}
    public int Year { get; set;}
    public required string Location { get; set;}
    
}