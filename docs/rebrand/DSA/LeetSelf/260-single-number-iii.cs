public class Solution {
    public int[] SingleNumber(int[] nums) {
        var xs = new List<int>();

        foreach(int n in nums){
            if (xs.Contains(n)){
                xs.Remove(n);
            }
            else{
                xs.Add(n);
            }
        }
        return new int[]{
            xs[0],
            xs[1]
        };
    }
}