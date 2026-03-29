public class MinWindowSolution {
    public string MinWindow(string s, string t) {
        /*
        Minimum Window Substring - HARD !
        
        sliding window
        for 0 to s.len check L
        move R++
        check each t.char char if has s.R.char
        if ok move R++ until get all
        if ok.all min = min(R-L,max), set min.r, min.l
        return min.r - min.l + 1
        */
        if (t.Length == 0) return string.Empty;

        int min = int.MaxValue;
        int L = 0;
        int R = 0;
        int n = s.Length;
        bool found = false;
        for(int i=0; i < n; i++)
        {
            var ks = new List<char>(t.ToCharArray());
            int j=i;
            bool all = false;
            for(; j < n; j++)
            {
                char c = s[j];
                if (ks.Contains(c))
                {
                    ks.Remove(c);
                    if (ks.Count == 0)
                    {
                        all = true;
                        break;
                    }
                }
            }
            if (j - i < min && all)
            {
                found = true;
                min = j - i;
                L = i;
                R = j;
            }
        }
        return found ? s.Substring(L, R-L+1) : string.Empty;
    }

    public static void Print()
    {
        var xs = new string[][]
        {
            new string[]{ "OUZODYXAZV", "XYZ", "YXAZ"},
            new string[]{ "a", "a", "a"},
            new string[]{ "a", "aa", ""},
        };

        foreach(var x in xs)
        {
            var r = new MinWindowSolution().MinWindow(x[0], x[1]);
            Console.WriteLine($"s={x[0]}, t={x[1]}, answer={x[2]} => mine={r} {(r == x[2] ? "OK" : "WRONG")}");
        }
    }
}
