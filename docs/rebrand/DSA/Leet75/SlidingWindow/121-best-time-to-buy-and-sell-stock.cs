public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int l = 0;
        int mn = int.MaxValue;
        while(l < prices.Length) {
            int p = prices[l];
            if (p < mn) {
                mn = p;
            }
            else {
                int d = p - mn;
                if (d > max) max = d;
            }
            l++;
        }
        return max;
    }
}