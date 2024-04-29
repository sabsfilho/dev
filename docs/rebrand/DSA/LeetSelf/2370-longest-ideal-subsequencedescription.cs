public class Solution {
    public int LongestIdealString(string s, int k) {
        int q = 1;
        var dp = new int[26]; //chars
        for(int i = 0; i < s.Length; i++){
            int c = s[i] -'a';
            for(int j = c;j>=0&&j>=c-k;j--){
                dp[c] = Math.Max(dp[c], dp[j]+1);
            }
            for(int j=c+1;j<26&&j<=c+k;j++){
                dp[c] = Math.Max(dp[c], dp[j]+1);
            }
            q = Math.Max(q, dp[c]);
        }
        return q;
    }
}