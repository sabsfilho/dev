public class Solution {
    public int CharacterReplacement(string s, int k) {

        int max = 0;

        var d = new Dictionary<char, int>(); //char[max 26 chars], q

        int l = 0;
        for(int r = 0; r < s.Length; r++) {
            var c = s[r];
            if (d.ContainsKey(c)){
                d[c]++;
            }
            else {
                d[c] = 1;
            }
            int len;
            while(true){
                len = r - l + 1;

                int mx = d.Values.Max(x=>x);

                if ((len - mx)<=k) break;

                d[s[l]]--;
                l++;
            }
            len = r - l + 1;
            if (len > max) max = len;
        }
        return max;
    }
}