public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        var sdic = new Dictionary<char,int>();
        var tdic = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++){
            Add(sdic, s[i]);
            Add(tdic, t[i]);
        }

        foreach(var x in sdic){
            int q;
            if (
                !tdic.TryGetValue(x.Key, out q) ||
                q != x.Value
            )
            return false;
        }

        return true;
    }
    static void Add(Dictionary<char,int> d, char c){
        if (d.ContainsKey(c)){
            d[c]++;
        }
        else {
            d[c] = 1;
        }
    }
}