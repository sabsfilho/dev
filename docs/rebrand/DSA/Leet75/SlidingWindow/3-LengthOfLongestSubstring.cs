public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int l = 0;
        var cs = new HashSet<char>();
        for(int i=0; i < s.Length; i++){
            char c = s[i];
            while (cs.Contains(c)){
                cs.Remove(s[l]);
                l++;
            }
            cs.Add(c);
            max = Math.Max(max, i-l+1);
        }
        return max;
    }
}