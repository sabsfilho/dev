using System.Text.Json;
using SoccerApp.Helpers;
using SoccerApp.Models;

namespace SoccerApp.Handlers;

public class TeamHandler{    
    public static Team[] LoadTeams(string country){
        return GetJSON(country);
    }
    static string GetTeamsPath(string country){
        string dir = string.Concat(
            AppContext.BaseDirectory, 
            $"fileIO/country/{country}"
        );
        if (!Directory.Exists(dir)){
            Directory.CreateDirectory(dir);
        }
        return dir;
    }
    static string GetTeamPath(string country, string teamId){
        return string.Concat(GetTeamsPath(country), "/team/", teamId, ".json");
    }
    static Team[] GetJSON(string country){
        string dir = GetTeamsPath(country);
        string pathJSON = $"{dir}/{country}.json";
        if (!File.Exists(pathJSON)){
            var html = GetHTMLCountry(country);
            if (html == ConstantHelper.NOT_FOUND){
                return new Team[0];
            }
            Team[] teams = ParseCountry(country, html);
            var json = JsonSerializer.Serialize(teams);
            File.WriteAllText(pathJSON, json);
            return teams;
        }
        else{
            var json = File.ReadAllText(pathJSON);
            return JsonSerializer.Deserialize<Team[]>(json);
        }
    }

    private static Team[] ParseCountry(string country, string html)
    {
        /*
        <a href="/squad.php?clubid=530">Albirex Niigata</a>
        <a href="/squad.php?clubid=530"><img class="lozad img-fluid img-thumbnail" src="https://cdn.soccerwiki.org/images/logos/clubs/530.png" data-src="https://cdn.soccerwiki.org/images/logos/clubs/530.png" alt="Albirex Niigata" width="70" height="70" style="border:0;width:70px !important;padding: 6px" data-loaded="true"></a>
        <td class="text-center" style="min-width:150px !important">1996</td>
        <td class="text-left" style="min-width:150px !important">Niigata</td>
        */
        string k = "href=\"/squad.php?clubid=";
        string k2 = "<td ";
        var tms = new List<Team>();
        int i = 0;
        while(i < html.Length){
            i = html.IndexOf(k, i);
            if (i == -1) break;
            i += k.Length;
            i = html.IndexOf(k, i);
            if (i == -1) break;
            i += k.Length;
            int j = html.IndexOf("\"", i);
            if (j == -1) break;
            string id = html.Substring(i, j - i);
            i = j;
            j = html.IndexOf("<", i);
            if (j == -1) break;
            i+=2;
            string nm = html.Substring(i, j - i);
            i = j;
            j = html.IndexOf(k2, i);
            if (j == -1) break;
            i = j + k2.Length;
            i = html.IndexOf(">", i);
            if (i == -1) break;
            i++;
            j = html.IndexOf("<", i);
            if (j == -1) break;
            string y = html.Substring(i, j - i);
            if (string.IsNullOrEmpty(y)) break;
            i = j;
            j = html.IndexOf(k2, i);
            if (j == -1) break;
            i = j + k2.Length;
            i = html.IndexOf(">", i);
            if (i == -1) break;
            i++;
            j = html.IndexOf("<", i);
            if (j == -1) break;
            string loc = html.Substring(i, j - i);
            if (string.IsNullOrEmpty(loc)) break;
            if (loc == "&nbsp;") continue;
            var tm = new Team(){
                Id = int.Parse(id),
                Name = nm,
                Year = int.Parse(y),
                Location = loc,
                CountryCode = country,
            };
            var json = JsonSerializer.Serialize(tm);
            File.WriteAllText(GetTeamPath(country, tm.Id.ToString()), json);
            if (tms.Count < 50){
            LoadTeam(tm);
            }
            tms.Add(tm);
            i++;
        }
        return tms.ToArray();
    }
    private static void LoadTeam(Team team)
    {
        var html = GetHTMLTeam(team.CountryCode, team.Id.ToString());
        if (html == ConstantHelper.NOT_FOUND){
            return;
        }
        ParseTeam(team, html);
    }

    private static void ParseTeam(Team team, string html)
    {
        int start = 0;
        int end = 0;
        ReadLeagueStadiumId(team, html, start, out end);
        if (end > -1) start = end;
        ReadStadium(team, html, start, out end);
        if (end > -1) start = end;
        ReadLeagueId(team, html, start, out end);
        if (end > -1) start = end;
        ReadLeague(team, html, start, out end);
    }

    private static void ReadLeagueStadiumId(Team team, string html, int startIndex, out int end)
    {
        team.StadiumId = ReadUrlId(team, html, "stadiumdid", startIndex, out end);
    }
    static void ReadLeagueId(Team team, string html, int startIndex, out int end){
        team.LeagueId = ReadUrlId(team, html, "leagueid", startIndex, out end);
    }

    static int ReadUrlId(Team team, string html, string k, int startIndex, out int end){
        k = string.Concat(k, "=");
        end = html.IndexOf(k, startIndex);
        if (end == -1) return 0;
        end += k.Length;
        int j = html.IndexOf("\"", end + 1);
        if (j == -1) return 0;
        string x = html.Substring(end, j - end);
        end += x.Length + 2;
        int id;
        if (!int.TryParse(x,out id)) return 0;
        return id;
    }
    static void ReadLeague(Team team, string html, int startIndex, out int end){
        string k = "</a>";
        end = html.IndexOf(k, startIndex);
        string x = html.Substring(startIndex, end - startIndex);
        end += k.Length;
        team.League = x;
    }
    static string ApenasDigitos(string n)
    {
        return string.Concat(n.Where(x => Char.IsDigit(x)));
    }
    static void ReadStadium(Team team, string html, int startIndex, out int end){
        string k = "</a>";
        end = html.IndexOf(k, startIndex);
        string x = html.Substring(startIndex, end - startIndex);
        end += k.Length;
        team.Statdium = x;
        startIndex = end;
        end = html.IndexOf("</p>", startIndex);
        x = html.Substring(startIndex, end - startIndex);
        x = ApenasDigitos(x);
        int id;
        if (!int.TryParse(x,out id)) return;
        team.Capacity = id;
        end += k.Length;
    }

    internal static string GetHTMLTeam(string country, string team){
        string dir = string.Concat(GetTeamsPath(country), "/team");
        return 
            GetHTML(
                dir,
                team,
                $"https://en.soccerwiki.org/squad.php?clubid={team}"
            );
    }
    static string GetHTMLCountry(string country){
        string dir = GetTeamsPath(country);
        return 
            GetHTML(
                dir,
                country,
                $"https://en.soccerwiki.org/country.php?countryId={country}"
            );
    }

    static string GetHTML(
        string dir,
        string code,
        string url
    ){
        string pathCSV = string.Concat(dir, $"/{code}.html");
        if (!File.Exists(pathCSV)){
            string html = HtmlHandler.LoadHtml(url);
            if (string.IsNullOrEmpty(html)){
                html = ConstantHelper.NOT_FOUND;
            }
            File.WriteAllText(pathCSV, html);
            return html;
        }
        else{
            return File.ReadAllText(pathCSV);
        }
    }
}