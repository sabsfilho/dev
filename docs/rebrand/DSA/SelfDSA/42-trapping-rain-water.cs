public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0) return 0;
        int[] ls = new int[n];
        int[] rs = new int[n];
        int l = 0;
        int r = n - 1;
        while(l < n){            
            ls[l] = Math.Max(height[l], l == 0 ? 0 : ls[l-1]);
            rs[r] = Math.Max(height[r], r == n-1 ? 0 : rs[r+1]);

            l++;
            r--;
        }
        int w = 0;
        for(int i = 0; i < n; i++){
            w += Math.Min(ls[i], rs[i]) - height[i];
        }
        return w;
    }
}