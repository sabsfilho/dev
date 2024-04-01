public class Solution {
    public int FindMin(int[] nums) {
        int v = nums[0];
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r){
            if (nums[l] < nums[r]) {
                v = Math.Min(v,nums[l]);
                break;
            }
            int m = (l + r) / 2;
            v = Math.Min(v, nums[m]);
            if (nums[m] >= nums[l]){
                l = m + 1;
            }
            else {
                r = m - 1;
            }

        }
        return v;
        //return nums.Min(x=>x);
    }
}