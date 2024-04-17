public class Solution {
    public int RomanToInt(string s) {
        var d = new Dictionary<char, int>(){
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int r = 0;
        for(int i=0; i < s.Length; i++) {           
            char c = s[i];
            int n = d[c];
            if (i < s.Length - 1) {
                char c2 = s[i+1];
                if ( 
                    c == 'I' &&
                    (c2 == 'V' || c2 == 'X')
                )
                {
                    n = d[c2] - n;
                    i++;
                }
                else if (
                    c == 'X' &&
                    (c2 == 'L' || c2 == 'C')
                )
                {
                    n = d[c2] - n;
                    i++;
                }
                else if (
                    c == 'C' &&
                    (c2 == 'D' || c2 == 'M')
                )
                {
                    n = d[c2] - n;
                    i++;
                }

            }
            r += n;
        }
        return r;
    }
}