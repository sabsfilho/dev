public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = nums.Sum();
        int sumleft = 0;
        for(int i=0;i<nums.Length;i++){
            int v = nums[i];
            int sumright = sum - sumleft - v;
            if (sumleft == sumright) return i;
            sumleft+=v;
        }
        return-1;
    }
}