public class Solution {
    public int FindMaxK(int[] nums) {
        var ns = new HashSet<int>();
        var ps = new HashSet<int>();

        int max = 0;

        foreach(int n in nums){
            if (n < 0){
                int abs = Math.Abs(n);
                if (ps.Contains(abs)){
                    if (abs > max) max = abs;
                }
                else {
                    ns.Add(abs);
                }
            }
            else {
                if (ns.Contains(n)){
                    if (n > max) max = n;
                }
                else {
                    ps.Add(n);
                }
            }
        }

        return max == 0 ? -1 : max;
        
    }
}