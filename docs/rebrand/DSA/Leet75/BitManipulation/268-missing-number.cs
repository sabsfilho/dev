public class Solution {
    public int MissingNumber(int[] nums) {
        var xs = new HashSet<int>(nums);
        int mx = 0;
        foreach(var n in nums) {
            if (n > 0 && !xs.Contains(n-1)){
                return n-1;
            }
            if (n > mx) mx = n;
        }
        return mx + 1;
    }
}