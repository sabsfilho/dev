public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while(l <= r){
            int m = (l+r)/2;
            int n = nums[m];
            if (n == target) return m;

            if (nums[l] <= n) {
                //left
                if (target > n || target < nums[l]){
                    l = m + 1;
                }
                else {
                    r = m - 1;
                }
            }
            else {
                //right
                if (target < n || target > nums[r]){
                    r = m - 1;
                }
                else {
                    l = m + 1;
                }
            }

        }

        return -1;
    }
}