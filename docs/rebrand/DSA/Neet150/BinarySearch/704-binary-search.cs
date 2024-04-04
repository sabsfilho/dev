public class Solution {
    public int Search(int[] nums, int target) {

        int l = 0;
        int r = nums.Length - 1;
        while (l <= r){
            int m = (l+r)/2;
            int n = nums[m];
            if (target == n) {
                return m;
            }
            if (target > n) {
                l = m+1;
            }
            else {
                r = m-1;
            }
        }
        return -1;        
    }
}