using System.Text.Json;
using SoccerApp.Helpers;
using SoccerApp.Models;

namespace SoccerApp.Handlers;

public class TeamHandler{
    public static Team[] LoadTeams(string country){
        return GetJSON(country);
    }
    static Team[] GetJSON(string country){
        string dir = string.Concat(AppContext.BaseDirectory, $"fileIO/teams");
        if (!Directory.Exists(dir)){
            Directory.CreateDirectory(dir);
        }
        string pathJSON = $"{dir}/{country}.json";
        if (!File.Exists(pathJSON)){
            var html = GetHTML(country);
            Team[] teams = Parse(country, html);
            var json = JsonSerializer.Serialize(teams);
            File.WriteAllText(pathJSON, json);
            return teams;
        }
        else{
            var json = File.ReadAllText(pathJSON);
            return JsonSerializer.Deserialize<Team[]>(json);
        }
    }

    private static Team[] Parse(string country, string html)
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
            tms.Add(tm);
            i++;
        }
        return tms.ToArray();
    }

    static string GetHTML(string country){
        string html = null;
        string pathCSV = string.Concat(AppContext.BaseDirectory, $"fileIO/teams/{country}.html");
        if (!File.Exists(pathCSV)){
            html = HtmlHandler.LoadHtml($"https://en.soccerwiki.org/country.php?countryId={country}");
            if (string.IsNullOrEmpty(html)){
                throw new Exception($"{country} not found");
            }
            File.WriteAllText(pathCSV, html);
        }
        else{
            html = File.ReadAllText(pathCSV);
        }
        return html;
    }
}