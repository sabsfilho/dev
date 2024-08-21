using System.Text.RegularExpressions;

public class Solution {
    public string ReverseWords(string s) {
        MatchCollection xs = new Regex("(\\b\\w+\\b)").Matches(s);
        
        string r = string.Empty;
        foreach(Match x in xs){
            if (r.Length > 0) r = string.Concat(" ", r);
            r = string.Concat(x.Value, r);
        }

        return r;
        
    }
}
