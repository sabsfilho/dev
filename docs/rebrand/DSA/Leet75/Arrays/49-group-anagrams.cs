public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var d = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            var ws = str.ToCharArray();
            Array.Sort(ws);
            var w = new String(ws);
            List<string> lst;
            if (!d.TryGetValue(w, out lst)){
                lst = new List<string>();
                d.Add(w, lst);
            }
            lst.Add(str);
        }
        var xs = new List<IList<string>>();

        foreach(var x in d){
            xs.Add(x.Value);
        }

        return xs;
    }
}