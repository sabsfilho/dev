public class Solution {
    public int LongestPalindrome(string s) {
        var d = new Dictionary<char, int>();
        foreach(char c in s){
            if (d.ContainsKey(c)){
                d[c]++;
            }
            else {
                d.Add(c,1);
            }            
        }
        if (d.Count == 1) return d.First().Value;

        int evenq = 0;
        var odds = new List<int>();
        foreach(var k in d) {
            int v = k.Value;
            bool even = v % 2 == 0;
            if (even) evenq += v;
            else odds.Add(v);
        }
        odds.Sort();
        for(int i=0; i < odds.Count; i++){
            int q = odds[i];
            if (i==0) evenq += q;
            else evenq += (q-1);
        }
        return evenq;
    }
}