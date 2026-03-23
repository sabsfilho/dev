public class IsPalindromeSolution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        while(l < r)
        {
            if (l == s.Length) break;            
            if (r < 0) break;
            char a = s[l];
            if (!char.IsLetterOrDigit(a))
            {
                l++;
                continue;
            }
            char b = s[r];
            if (!char.IsLetterOrDigit(b))
            {
                r--;
                continue;
            }
            if (a.ToString().ToLower() != b.ToString().ToLower())
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
