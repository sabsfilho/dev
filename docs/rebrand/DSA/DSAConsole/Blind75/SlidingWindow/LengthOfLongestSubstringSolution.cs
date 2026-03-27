public class LengthOfLongestSubstringSolution {
    public int LengthOfLongestSubstring(string s) {
        /*
        zxyz => L == R , L++ | L != R , R++
        */
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;
        int max = 0;
        int n = s.Length - 1;

        int L = 0;
        int R = 1;

        while(R <= n)
        {
            if (L == n || R < 0) break;

            if (s[L] == s[R])
            {
                if (max == 0)
                {
                    max = 1;
                }
                L++;
                if (L == R) 
                {
                    R++;
                }
            }
            else
            {
                for(int i=L; i < R; i++)
                {
                    if (s[i] == s[R])
                    {
                        L = i+1;
                        break;
                    }
                }
                max = Math.Max(R - L + 1, max);
                R++;
            }
        }

        return max;
    }
}
