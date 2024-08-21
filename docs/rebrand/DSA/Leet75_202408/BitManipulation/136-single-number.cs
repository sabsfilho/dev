public class Solution {
    public int SingleNumber(int[] nums) {
        int v = 0;
        for(int i=0;i<nums.Length;i++) {
            v = v ^ nums[i];
        }
        return v;
    }
}