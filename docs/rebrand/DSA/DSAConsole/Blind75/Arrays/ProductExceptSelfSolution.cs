public class ProductExceptSelfSolution {
    public int[] ProductExceptSelf(int[] nums) {
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
