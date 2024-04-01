public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var xs = new int[n];
        int x = 1;
        for(int i = 0; i < n; i++){
            xs[i] = x;
            x *= nums[i];
        }
        x = 1;
        for(int i = n-1; i>= 0; i--){
            xs[i] *= x;
            x *= nums[i];
        }
        return xs;
    }
}