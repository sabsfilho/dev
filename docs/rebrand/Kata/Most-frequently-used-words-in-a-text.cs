using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class TopWords
{
    public static List<string> Top3(string s)
    {
      Console.WriteLine(s);
      if (string.IsNullOrEmpty(s)) return new List<string>();
      
      var xs = Regex.Matches(s, @"[A-Za-z0-9']+", RegexOptions.IgnoreCase);
      var d = new Dictionary<string, int>();
      foreach(var x in xs){
        string w = x.ToString().ToLower();
        
		    if (!Regex.IsMatch(w, @"\w")) continue;
        
        int q = 0;
        if (!d.TryGetValue(w, out q)){
          d[w] = 1;
        }
        else{
          d[w] = q + 1;
        }
      }
      return 
        d
        .OrderByDescending(x=>x.Value)
        .Take(3)
        .Select(x=>x.Key)
        .ToList();
    }
}