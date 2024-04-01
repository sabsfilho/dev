public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int mx = 0;
        int q = 1;
        for(int i=1;i<nums.Length;i++){
            if (nums[i]==nums[i-1]) continue;
            if (nums[i]-nums[i-1]==1){
                q++;
            }
            else{
                if (q>mx) mx = q;
                q = 1;
            }
        }
        if (q>mx) mx = q;
        return mx;
    }
}