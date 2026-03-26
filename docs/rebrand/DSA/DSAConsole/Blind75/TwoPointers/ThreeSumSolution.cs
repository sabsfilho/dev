public class ThreeSumSolution {
    public List<List<int>> ThreeSum(int[] nums) {
        /*
        a + b + c = 0
        a = -(b + c)

        each a in nums
            a > 0 break

        slide windows of b, c => L, R

        d = (a + b + c)

        if d == 0 => add a, b, c ; while b==c => L++ ;  next a

        if d > 0 => R--

        if d < 0 => L++

        */
        List<List<int>> rs = new List<List<int>>();

        Array.Sort(nums);

        int len = nums.Length;
        
        for(int i=0; i < len; i++)
        {
            int a = nums[i];
            if (a > 0) break;
            if (i > 0 && a == nums[i - 1]) continue;
            int L = i + 1;
            int R = len - 1;
            while(L < R)
            {
                if (L >= len || R < 0 ) break;

                int b=nums[L];

                int c=nums[R];

                int d = (a + b + c);

                if (d > 0) 
                {
                    R--;
                    continue;
                }

                if (d < 0)
                {
                    L++;
                    continue;
                }

                rs.Add(new List<int>(){ a, b, c });

                L++;
                R--;

                while (L < R && nums[L] == nums[L-1])
                {
                    L++;
                }
            }
        }

        return rs;

    }
    public List<List<int>> ThreeSumN3(int[] nums) {
        List<List<int>> rs = new List<List<int>>();
        var ws = new HashSet<string>();
        int n = nums.Length;
        for(int i=0; i < n; i++)
        {
            for(int j=i+1; j < n; j++)
            {
                for(int k=j+1; k<n; k++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    int c = nums[k];

                    if (a + b + c == 0)
                    {
                        var xs = new int[]{ a, b, c};
                        Array.Sort(xs);
                        string w = string.Join("-", xs);
                        if (!ws.Contains(w))
                        {
                            ws.Add(w);
                            rs.Add(xs.ToList());
                        }
                    }

                }
            }
        }
        return rs;
    }
}
