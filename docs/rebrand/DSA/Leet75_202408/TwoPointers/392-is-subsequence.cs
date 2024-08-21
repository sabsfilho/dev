public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = 0;
        for(int i=0;i<s.Length;i++) {
            char a = s[i];
            bool found = false;
            while(j < t.Length) {
                char b = t[j];
                j++;
                if (a == b) {
                    found = true;    
                    break;                
                }
            }
            if (!found) return false;
        }
        return true;
    }
}