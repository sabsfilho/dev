public class ProductExceptSelfSolution {
    public int[] ProductExceptSelf(int[] nums) {
        /*
        0: 2*4*6=48 => L=, R=6*4*2
        1: 1*4*6=24 => L=1, R=6*4
        2: 1*2*6=12 => L=1*2, R=6
        3: 1*2*4=8 => L=1*2*4, R=
        */
        int n = nums.Length;
        int[] rs = new int[n];

        int L = 1;
        for(int i=0;i < n; i++)
        {
            rs[i] = L;
            L *= nums[i];
        }
        int R = 1;
        for(int i=n-1;i >= 0; i--)
        {
            rs[i] *= R;
            R *= nums[i];
        }

        return rs;
    }
    public int[] ProductExceptSelfN2(int[] nums) {
        /*
        0: 2*4*6=48
        1: 1*4*6=24
        2: 1*2*6=12
        3: 1*2*4=8
        */
        int n = nums.Length;
        int[] rs = new int[n];
        bool[] oks = new bool[n];
        for(int i=0; i < n; i++)
        {
            for(int j=0; j < n; j++)
            {
                if (i != j)
                {
                    if (oks[i])
                    {
                        rs[i] *= nums[j];
                    } 
                    else 
                    {
                        rs[i] = nums[j];
                        oks[i] = true;
                    }
                }
            }
        }
        return rs;
    }
}
