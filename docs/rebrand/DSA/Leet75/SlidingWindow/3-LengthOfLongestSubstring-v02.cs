public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        var cs = new HashSet<char>();
        var qs = new Queue();
        for(int i = 0; i < s.Length; i++){
            var c = s[i];
            if (i > 0 && cs.Contains(c)){
                if (cs.Count > max) max = cs.Count;
                if(s[i-1] == c) {
                    cs.Clear();
                    cs.Add(c);
                    qs.Clear();
                    qs.Enqueue(c);
                    continue;
                }

                while(qs.Count > 0){
                    char v = (char) qs.Dequeue();
                    if (v == c) break;
                    cs.Remove(v);
                }
                qs.Enqueue(c);
            }
            else {
                cs.Add(c);
                qs.Enqueue(c);
            }
        }
        if (cs.Count > max) max = cs.Count;
        return max;
    }
}