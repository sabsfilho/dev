public class CharacterReplacementSolution {
    public int CharacterReplacement(string s, int k) {
        if (string.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;

        int max = 1;
        int q = 0;

        int n = s.Length - 1;
        
        for (int i = 0; i <= n; i++) {
            int L = i;
            int R = i + 1;
            q = 0;
            while (R <= n) {
                if (s[L] != s[R]) {
                    if (q < k) {
                        q++;
                    } else {
                        break;
                    }
                }
                max = Math.Max(R - L + 1, max);
                R++;
            }
            max = Math.Max(max, Math.Min(s.Length, (R - L) + (k - q)));
        }
        
        return max;
    }
}