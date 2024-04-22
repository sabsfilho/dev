using System.Text.Json;
using SoccerApp.Helpers;
using SoccerApp.Models;

namespace SoccerApp.Handlers;

public class PlayerHandler{
    public static Player LoadPlayer(string country, string playerId){
        return GetJSONPlayer(country, playerId)!;
    }
    public static Player[] LoadPlayers(string country, IEnumerable<int> playerIds){
        return playerIds.Select(playerId => LoadPlayer(country, playerId.ToString())).ToArray();
    }

    static string GetPlayerPath(string country){
        string dir = string.Concat(
            AppContext.BaseDirectory, 
            $"fileIO/country/{country}/player"
        );
        if (!Directory.Exists(dir)){
            Directory.CreateDirectory(dir);
        }
        return dir;
    }
    static Player? GetJSONPlayer(string country, string playerId){
        string dir = GetPlayerPath(country);
        string pathJSON = $"{dir}/{playerId}.json";
        if (!File.Exists(pathJSON)){
            var html = GetHTMLPlayer(country, playerId);
            if (html == ConstantHelper.NOT_FOUND){
                return null;
            }
            Player player = ParsePlayer(country, playerId, html);
            var json = JsonSerializer.Serialize(player);
            File.WriteAllText(pathJSON, json);
            return player;
        }
        else{
            var json = File.ReadAllText(pathJSON);
            return JsonSerializer.Deserialize<Player>(json);
        }
    }

    private static Player ParsePlayer(string country, string playerId, string html)
    {
        return null;
    }

    static string GetHTMLPlayer(string country, string playerId){
        string dir = GetPlayerPath(country);
        string pathCSV = string.Concat(dir, $"/{playerId}.html");
        if (!File.Exists(pathCSV)){
            string html = HtmlHandler.LoadHtml($"https://en.soccerwiki.org/player.php?pid={country}");
            if (string.IsNullOrEmpty(html)){
                return ConstantHelper.NOT_FOUND;
            }
            File.WriteAllText(pathCSV, html);
            return html;
        }
        else{
            return File.ReadAllText(pathCSV);
        }
    }

    internal static void WriteFile(Player p){
        var json = JsonSerializer.Serialize(p);
        string dir = GetPlayerPath(p.CountryCode);
        string pathJSON = $"{dir}/{p.Id}.json";
        File.WriteAllText(pathJSON, json);
    }
}