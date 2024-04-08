public class Solution {
    public int MaxDepth(string s) {
        int max = 0;
        int o = '(';
        int c = ')';
        int q = 0;
        for(int i = 0; i < s.Length; i++) {
            char x = s[i];
            if (x == o) {
                q++;
            }
            else if (x == c) {
                if (q > max) {
                    max = q;
                }
                q--;
            }
        }
        return max;
    }
}