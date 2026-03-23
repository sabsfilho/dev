public class LongestConsecutiveSolution {
    public int LongestConsecutive(int[] nums) {
        /*
        sort, get max sequence
        o(n+n)
        */
        if (nums.Length == 0) return 0;
        int max = 1;
        int mx = 1;
        Array.Sort(nums);
        for(int i=1;i < nums.Length;i++)
        {
            int a = nums[i-1];
            int b = nums[i];
            if (a==b) continue;
            if (a+1==b)
            {
                mx++;
            }
            else
            {
                if (mx > max) max = mx;
                mx = 1;
            }
        }
        if (mx > max) max = mx;

        return max;
    }
}
