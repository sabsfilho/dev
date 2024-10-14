public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {

        var lst = new List<IList<int>>();

        Array.Sort(nums);
        
        int len = nums.Length;

        var map = new HashSet<string>();

        for(int i = 0; i < len; i++)
        {
            int a = nums[i];
            if (i > 0 && nums[i-1] == a) continue;
            int L = i + 1;
            int R = len-1;
            while(L < R)
            {
                int b = nums[L];
                int L2 = L + 1;
                while (L2 < R)
                {
                    int c = nums[L2];
                    int d = nums[R];
                    int sum = a+b+c+d;
                    if (a > 0 && b > 0 && c > 0 && d > 0 && sum < 0)
                    {
                        break;
                    }
                    if (sum == target)
                    {
                        while(L2 < R && c == nums[L2+1]) L2++;
                        while(L2 < R && d == nums[R-1]) R--;
                        L2++;
                        R--;
                        var zs = new int[]{ a, b, c, d };
                        string k = string.Join('-', zs);
                        if (!map.Contains(k)){
                            map.Add(k);
                            lst.Add(zs);
                        }
                    }
                    else if (sum > target)
                        R--;
                    else
                        L2++;

                }
                L++;
                R = len - 1;
            }
        }

        return lst;
        
    }
}