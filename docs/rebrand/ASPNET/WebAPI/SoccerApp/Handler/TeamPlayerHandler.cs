using System.Text.Json;
using SoccerApp.Helpers;
using SoccerApp.Models;

namespace SoccerApp.Handlers;

public class TeamPlayerHandler{
    public static Player[] LoadTeamPlayers(string country, string teamId){
        var xs = LoadTeamPlayersInternal(country, teamId);
        if (xs == null) { 
            return LoadTeamPlayersInternal(country, teamId)!;
        }
        return xs!;
    }
    static Player[]? LoadTeamPlayersInternal(string country, string teamId){
        var tps = GetJSON(country, teamId);
        if (tps == null) return Array.Empty<Player>();
        if (tps.TeamId == 0 || tps.PlayerIds == null) {
            Delete(country, teamId);
        }
        if (tps.Players == null && tps.PlayerIds != null){
            return PlayerHandler.LoadPlayers(country, tps.PlayerIds!);
        }
        else {
            return tps.Players;
        }
    }



    private static void Delete(string country, string teamId)
    {
        string dir = GetPath(country, teamId);
        string pathJSON = $"{dir}/{teamId}.json";
        if (File.Exists(pathJSON)){
            File.Delete(pathJSON);
        }
    }

    static string GetPath(string country, string teamId){
        string dir = string.Concat(
            AppContext.BaseDirectory, 
            $"fileIO/country/{country}/teamplayer"
        );
        if (!Directory.Exists(dir)){
            Directory.CreateDirectory(dir);
        }
        return dir;
    }

    static TeamPlayer? GetJSON(string country, string teamId){
        string dir = GetPath(country, teamId);
        string pathJSON = $"{dir}/{teamId}.json";
        if (!File.Exists(pathJSON)){
            var html = TeamHandler.GetHTMLTeam(country, teamId);
            if (html == ConstantHelper.NOT_FOUND){
                return null;
            }
            TeamPlayer player = Parse(country, teamId, html);
            var json = JsonSerializer.Serialize(player);
            File.WriteAllText(pathJSON, json);
            return player;
        }
        else{
            var json = File.ReadAllText(pathJSON);
            return JsonSerializer.Deserialize<TeamPlayer>(json);
        }
    }

    private static TeamPlayer Parse(string country, string teamId, string html)
    {
        var tp = new TeamPlayer();
        var tms = new List<Player>();
        int i = html.IndexOf("id=\"datatable\"");
        if (i == -1) return tp;
        i = html.IndexOf("<tbody>");
        if (i == -1) return tp;
        while(i < html.Length){
            i = html.IndexOf("<tr ", i);
            if (i == -1) break;
            var p = new Player(){
                Name = string.Empty,
                CountryCode = country,
                TeamId = teamId
            };
            int end = 0;
            p.SquadNumber = ReadTDInt(html, i, out end);
            p.Nationality = ReadValue(ReadTD(html, end, out end), "countryId=", "\"");
            string nm = ReadTD(html, end, out end)!;
            p.Id = int.Parse(ReadValue(nm, "pid=", "\"")!);
            p.Name = ReadValue(nm, "alt=\"", "\"")!;
            ReadTD(html, end, out end);
            p.Position = ReadValue(ReadTD(html, end, out end), "title=\"", "\"");
            p.Age = ReadTDInt(html, end, out end);
            p.Rank = ReadTDInt(html, end, out end);
            i = end + 1;
            tms.Add(p);
            PlayerHandler.WriteFile(p);
        }
        tp.TeamId = int.Parse(teamId);
        tp.PlayerIds = tms.Select(x => x.Id).ToArray();
        tp.Players = tms.ToArray();
        return tp;
    }

    private static string? ReadValue(string? txt, string start, string end)
    {
        if (txt == null) return null;
        int j = txt.IndexOf(start);
        if (j == -1) return null;
        j += start.Length;
        int y = txt.IndexOf(end, j);
        if (y == -1) return null;
        return txt.Substring(j, y - j);
    }

    private static string? ReadTD(string html, int start, out int end)
    {
        end = start;
        if (start == -1) return null;
        int j = html.IndexOf("<td ", start);
        if (j == -1) return null;
        j = html.IndexOf(">", j);
        if (j == -1) return null;
        start = j + 1;
        string k = "</td>";
        j = html.IndexOf(k, start);
        if (j == -1) return null;
        string x = html.Substring(start, j - start);
        j += k.Length;
        end = j;
        return x;
    }

    private static int ReadTDInt(string html, int start, out int end)
    {
        int n;
        var x = ReadTD(html, start, out end);
        return int.TryParse(x, out n) ? n : 0;
    }
}