public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int q = 0;
        string r = string.Empty;
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if (c == '(') {
                q++;
            }
            else if (c == ')'){
                if (q == 0) continue;
                q--;
            }
            r = string.Concat(r, c);
        }
        if (q > 0) {
            var xs = r.ToCharArray().ToList();
            int j = r.Length;
            for(int i = q; i > 0; i--){             
                char c = '@';   
                while(j > 0 && c != '('){                    
                    j--;
                    c = r[j];
                }
                if (c == '(') {
                    xs.RemoveAt(j);
                }
            }
            r = new String(xs.ToArray());
        }
        return r;
    }
}