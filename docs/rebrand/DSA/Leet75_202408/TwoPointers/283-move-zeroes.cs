public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i=1; i < nums.Length; i++){
            int a = nums[i-1];
            if (a != 0) {
                continue;
            }
            bool found = false;
            for(int j=i; j < nums.Length; j++){
                int b = nums[j];
                if (b != 0) {
                    //swap
                    int c = nums[i-1];
                    nums[i-1] = nums[j];
                    nums[j] = c;
                    found = true;
                    break;
                }
            }
            if (!found) {
                return;
            }
        }
    }
}