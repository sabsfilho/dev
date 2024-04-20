namespace SoccerApp.Helpers;

public class HtmlHandler
{
    public static string LoadHtml(string path)
    {
        using (var client = new HttpClient())
        {
            var x = client.GetStringAsync(path);
            x.Wait();
            return x.Result;
        }
    }
}