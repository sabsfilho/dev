public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var d = new Dictionary<int, int>(); //num,idx
        for(int i = 0; i < nums.Length; i++){
            int a = nums[i];
            int b = target - a;
            int idx;
            if (d.TryGetValue(b, out idx)) {
                return new int[2]{ idx, i };
            }
            d[a] = i;
        }
        return new int[2];
    }
}